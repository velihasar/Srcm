
using Business.BusinessAspects;
using Business.Constants;
using Business.Handlers.Sinavs.ValidationRules;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Extensions;
using Core.Utilities.Results;
using DataAccess.Abstract;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.Sinavs.Commands
{
    public class UpdateSinavCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string KisaAd { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }

        public class UpdateSinavCommandHandler : IRequestHandler<UpdateSinavCommand, IResult>
        {
            private readonly ISinavRepository _sinavRepository;
            private readonly IMediator _mediator;

            public UpdateSinavCommandHandler(ISinavRepository sinavRepository, IMediator mediator)
            {
                _sinavRepository = sinavRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(UpdateSinavValidator), Priority = 1)]
            //[CacheRemoveAspect("Get")]
            //[LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(UpdateSinavCommand request, CancellationToken cancellationToken)
            {
                var isThereSinavRecord = await _sinavRepository.GetAsync(u => u.Id == request.Id);

                isThereSinavRecord.KisaAd = request.KisaAd;
                isThereSinavRecord.Ad = request.Ad;
                isThereSinavRecord.SiraNo = request.SiraNo;
                isThereSinavRecord.UpdatedDate = DateTime.Now;
                isThereSinavRecord.UpdatedBy = UserInfoExtensions.GetUserId();

                _sinavRepository.Update(isThereSinavRecord);
                await _sinavRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Updated);
            }
        }
    }
}
