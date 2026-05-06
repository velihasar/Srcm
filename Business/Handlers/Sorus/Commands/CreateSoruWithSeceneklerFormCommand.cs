using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.BusinessAspects;
using Business.Constants;
using Business.Handlers.Sorus.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Entities.Concrete.Project;
using Core.Extensions;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Business.Handlers.Sorus.Commands
{
    /// <summary>
    /// Form alanlarıyla soru + 4 veya 5 şık. GorselUrl yok; SoruId istemciden gelmez.
    /// </summary>
    public class CreateSoruWithSeceneklerFormCommand : IRequest<IResult>
    {
        public int KonuId { get; set; }
        public string SoruMetin { get; set; }
        public string SecenekMetin1 { get; set; }
        public string SecenekMetin2 { get; set; }
        public string SecenekMetin3 { get; set; }
        public string SecenekMetin4 { get; set; }
        /// <summary>Boş bırakılırsa yalnızca 4 şık kaydedilir.</summary>
        public string SecenekMetin5 { get; set; }
        /// <summary>Dolu şıklar arasında 1 tabanlı sıra (4 şıkta 1–4, 5 şıkta 1–5).</summary>
        public int DogruSecenekNo { get; set; }
        public int ErisimSeviyesi { get; set; } = 1;

        public class CreateSoruWithSeceneklerFormCommandHandler : IRequestHandler<CreateSoruWithSeceneklerFormCommand, IResult>
        {
            private readonly ISoruRepository _soruRepository;
            private readonly ISoruSecenekRepository _soruSecenekRepository;
            private readonly IKonuRepository _konuRepository;
            private readonly ProjectDbContext _db;

            public CreateSoruWithSeceneklerFormCommandHandler(
                ISoruRepository soruRepository,
                ISoruSecenekRepository soruSecenekRepository,
                IKonuRepository konuRepository,
                ProjectDbContext db)
            {
                _soruRepository = soruRepository;
                _soruSecenekRepository = soruSecenekRepository;
                _konuRepository = konuRepository;
                _db = db;
            }

            [ValidationAspect(typeof(CreateSoruWithSeceneklerFormValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(CreateSoruWithSeceneklerFormCommand request, CancellationToken cancellationToken)
            {
                var konu = await _konuRepository.GetAsync(k => k.Id == request.KonuId && k.IsDeleted != true);
                if (konu == null)
                {
                    return new ErrorResult("Konu bulunamadı.");
                }

                var maxSira = await _soruRepository.Query()
                    .Where(s => s.KonuId == request.KonuId && s.IsDeleted != true)
                    .Select(s => (int?)s.SiraNo)
                    .MaxAsync(cancellationToken) ?? 0;

                var soru = new Soru
                {
                    KonuId = request.KonuId,
                    Metin = request.SoruMetin?.Trim(),
                    GorselUrl = null,
                    SiraNo = maxSira + 1,
                    ErisimSeviyesi = request.ErisimSeviyesi,
                    CreatedBy = UserInfoExtensions.GetUserId(),
                    CreatedDate = DateTime.Now
                };

                var metinler = new List<string>
                {
                    request.SecenekMetin1?.Trim(),
                    request.SecenekMetin2?.Trim(),
                    request.SecenekMetin3?.Trim(),
                    request.SecenekMetin4?.Trim()
                };
                if (!string.IsNullOrWhiteSpace(request.SecenekMetin5))
                {
                    metinler.Add(request.SecenekMetin5.Trim());
                }

                var anahtarlar = new[] { "A", "B", "C", "D", "E" };

                await using IDbContextTransaction tx = await _db.Database.BeginTransactionAsync(cancellationToken);
                try
                {
                    _soruRepository.Add(soru);
                    await _db.SaveChangesAsync(cancellationToken);

                    for (var i = 0; i < metinler.Count; i++)
                    {
                        var secenek = new SoruSecenek
                        {
                            SoruId = soru.Id,
                            Anahtar = anahtarlar[i],
                            Metin = metinler[i],
                            GorselUrl = null,
                            DogruMu = request.DogruSecenekNo == i + 1,
                            CreatedBy = UserInfoExtensions.GetUserId(),
                            CreatedDate = DateTime.Now
                        };
                        _soruSecenekRepository.Add(secenek);
                    }

                    await _db.SaveChangesAsync(cancellationToken);
                    await tx.CommitAsync(cancellationToken);
                }
                catch
                {
                    await tx.RollbackAsync(cancellationToken);
                    throw;
                }

                return new SuccessResult(Messages.Added);
            }
        }
    }
}
