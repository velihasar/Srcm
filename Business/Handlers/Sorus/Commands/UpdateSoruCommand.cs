
using Business.Constants;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Core.Aspects.Autofac.Validation;
using Business.Handlers.Sorus.ValidationRules;


namespace Business.Handlers.Sorus.Commands
{


    public class UpdateSoruCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int KonuId { get; set; }
        public string Metin { get; set; }
        public string GorselUrl { get; set; }
        public int SiraNo { get; set; }
        public int ErisimSeviyesi { get; set; }

        public class UpdateSoruCommandHandler : IRequestHandler<UpdateSoruCommand, IResult>
        {
            private readonly ISoruRepository _soruRepository;
            private readonly IMediator _mediator;

            public UpdateSoruCommandHandler(ISoruRepository soruRepository, IMediator mediator)
            {
                _soruRepository = soruRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(UpdateSoruValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(UpdateSoruCommand request, CancellationToken cancellationToken)
            {
                var isThereSoruRecord = await _soruRepository.GetAsync(u => u.Id == request.Id);


                isThereSoruRecord.KonuId = request.KonuId;
                isThereSoruRecord.Metin = request.Metin;
                isThereSoruRecord.GorselUrl = request.GorselUrl;
                isThereSoruRecord.SiraNo = request.SiraNo;
                isThereSoruRecord.ErisimSeviyesi = request.ErisimSeviyesi;


                _soruRepository.Update(isThereSoruRecord);
                await _soruRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Updated);
            }
        }
    }
}

