
using Business.BusinessAspects;
using Business.Constants;
using Business.Handlers.Konus.ValidationRules;
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


namespace Business.Handlers.Konus.Commands
{


    public class UpdateKonuCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int BolumId { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }

        public class UpdateKonuCommandHandler : IRequestHandler<UpdateKonuCommand, IResult>
        {
            private readonly IKonuRepository _konuRepository;
            private readonly IMediator _mediator;

            public UpdateKonuCommandHandler(IKonuRepository konuRepository, IMediator mediator)
            {
                _konuRepository = konuRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(UpdateKonuValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(UpdateKonuCommand request, CancellationToken cancellationToken)
            {
                var isThereKonuRecord = await _konuRepository.GetAsync(u => u.Id == request.Id);


                isThereKonuRecord.BolumId = request.BolumId;
                isThereKonuRecord.Ad = request.Ad;
                isThereKonuRecord.SiraNo = request.SiraNo;
                isThereKonuRecord.UpdatedDate = DateTime.Now;
                isThereKonuRecord.UpdatedBy = UserInfoExtensions.GetUserId();


                _konuRepository.Update(isThereKonuRecord);
                await _konuRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Updated);
            }
        }
    }
}

