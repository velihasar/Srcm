
using Business.BusinessAspects;
using Business.Constants;
using Business.Handlers.Bolums.ValidationRules;
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

namespace Business.Handlers.Bolums.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateBolumCommand : IRequest<IResult>
    {

        public int SinavId { get; set; }
        public string Ad { get; set; }
        public int SiraNo { get; set; }


        public class CreateBolumCommandHandler : IRequestHandler<CreateBolumCommand, IResult>
        {
            private readonly IBolumRepository _bolumRepository;
            private readonly IMediator _mediator;
            public CreateBolumCommandHandler(IBolumRepository bolumRepository, IMediator mediator)
            {
                _bolumRepository = bolumRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(CreateBolumValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(CreateBolumCommand request, CancellationToken cancellationToken)
            {
                var isThereBolumRecord = _bolumRepository.Query().Any(u => u.SinavId == request.SinavId);

                if (isThereBolumRecord == true)
                    return new ErrorResult(Messages.NameAlreadyExist);

                var addedBolum = new Bolum
                {
                    SinavId = request.SinavId,
                    Ad = request.Ad,
                    SiraNo = request.SiraNo,
                    CreatedBy = UserInfoExtensions.GetUserId(),
                    CreatedDate = DateTime.Now,
                };

                _bolumRepository.Add(addedBolum);
                await _bolumRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Added);
            }
        }
    }
}