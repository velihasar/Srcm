
using Business.BusinessAspects;
using Business.Constants;
using Business.Handlers.Bolums.ValidationRules;
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


namespace Business.Handlers.Bolums.Commands
{


    public class UpdateBolumCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int SinavId { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }

        public class UpdateBolumCommandHandler : IRequestHandler<UpdateBolumCommand, IResult>
        {
            private readonly IBolumRepository _bolumRepository;
            private readonly IMediator _mediator;

            public UpdateBolumCommandHandler(IBolumRepository bolumRepository, IMediator mediator)
            {
                _bolumRepository = bolumRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(UpdateBolumValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(UpdateBolumCommand request, CancellationToken cancellationToken)
            {
                var isThereBolumRecord = await _bolumRepository.GetAsync(u => u.Id == request.Id);


                isThereBolumRecord.SinavId = request.SinavId;
                isThereBolumRecord.Ad = request.Ad;
                isThereBolumRecord.SiraNo = request.SiraNo;
                isThereBolumRecord.UpdatedDate = DateTime.Now;
                isThereBolumRecord.UpdatedBy = UserInfoExtensions.GetUserId();

                _bolumRepository.Update(isThereBolumRecord);
                await _bolumRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Updated);
            }
        }
    }
}

