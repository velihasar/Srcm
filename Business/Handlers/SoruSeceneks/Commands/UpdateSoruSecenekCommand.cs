
using Business.BusinessAspects;
using Business.Constants;
using Business.Handlers.SoruSeceneks.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Extensions;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Business.Handlers.SoruSeceneks.Commands
{


    public class UpdateSoruSecenekCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int SoruId { get; set; }
        public string Anahtar { get; set; }
        public string Metin { get; set; }
        public string GorselUrl { get; set; }
        public bool DogruMu { get; set; }

        public class UpdateSoruSecenekCommandHandler : IRequestHandler<UpdateSoruSecenekCommand, IResult>
        {
            private readonly ISoruSecenekRepository _soruSecenekRepository;
            private readonly IMediator _mediator;

            public UpdateSoruSecenekCommandHandler(ISoruSecenekRepository soruSecenekRepository, IMediator mediator)
            {
                _soruSecenekRepository = soruSecenekRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(UpdateSoruSecenekValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(UpdateSoruSecenekCommand request, CancellationToken cancellationToken)
            {
                var isThereSoruSecenekRecord = await _soruSecenekRepository.GetAsync(u => u.Id == request.Id);


                isThereSoruSecenekRecord.SoruId = request.SoruId;
                isThereSoruSecenekRecord.Anahtar = request.Anahtar;
                isThereSoruSecenekRecord.Metin = request.Metin;
                isThereSoruSecenekRecord.GorselUrl = request.GorselUrl;
                isThereSoruSecenekRecord.DogruMu = request.DogruMu;
                isThereSoruSecenekRecord.UpdatedDate = DateTime.Now;
                isThereSoruSecenekRecord.UpdatedBy = UserInfoExtensions.GetUserId();


                _soruSecenekRepository.Update(isThereSoruSecenekRecord);
                await _soruSecenekRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Updated);
            }
        }
    }
}

