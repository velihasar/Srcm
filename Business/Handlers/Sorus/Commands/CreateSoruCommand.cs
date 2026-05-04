
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
using Entities.Concrete;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.Sorus.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSoruCommand : IRequest<IResult>
    {

        public int KonuId { get; set; }
        public string Metin { get; set; }
        public string GorselUrl { get; set; }
        public int SiraNo { get; set; }
        public int ErisimSeviyesi { get; set; }


        public class CreateSoruCommandHandler : IRequestHandler<CreateSoruCommand, IResult>
        {
            private readonly ISoruRepository _soruRepository;
            private readonly IMediator _mediator;
            public CreateSoruCommandHandler(ISoruRepository soruRepository, IMediator mediator)
            {
                _soruRepository = soruRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(CreateSoruValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(CreateSoruCommand request, CancellationToken cancellationToken)
            {
                var isThereSoruRecord = _soruRepository.Query().Any(u => u.KonuId == request.KonuId);

                if (isThereSoruRecord == true)
                    return new ErrorResult(Messages.NameAlreadyExist);

                var addedSoru = new Soru
                {
                    KonuId = request.KonuId,
                    Metin = request.Metin,
                    GorselUrl = request.GorselUrl,
                    SiraNo = request.SiraNo,
                    ErisimSeviyesi = request.ErisimSeviyesi,
                    CreatedBy = UserInfoExtensions.GetUserId(),
                    CreatedDate = DateTime.Now,

                };

                _soruRepository.Add(addedSoru);
                await _soruRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Added);
            }
        }
    }
}