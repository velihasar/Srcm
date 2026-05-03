
using Business.BusinessAspects;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Business.Handlers.SoruSeceneks.ValidationRules;
using Core.Entities.Concrete.Project;

namespace Business.Handlers.SoruSeceneks.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSoruSecenekCommand : IRequest<IResult>
    {

        public int SoruId { get; set; }
        public string Anahtar { get; set; }
        public string metin { get; set; }
        public string GorselUrl { get; set; }
        public bool DogruMu { get; set; }


        public class CreateSoruSecenekCommandHandler : IRequestHandler<CreateSoruSecenekCommand, IResult>
        {
            private readonly ISoruSecenekRepository _soruSecenekRepository;
            private readonly IMediator _mediator;
            public CreateSoruSecenekCommandHandler(ISoruSecenekRepository soruSecenekRepository, IMediator mediator)
            {
                _soruSecenekRepository = soruSecenekRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(CreateSoruSecenekValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(CreateSoruSecenekCommand request, CancellationToken cancellationToken)
            {
                var isThereSoruSecenekRecord = _soruSecenekRepository.Query().Any(u => u.SoruId == request.SoruId);

                if (isThereSoruSecenekRecord == true)
                    return new ErrorResult(Messages.NameAlreadyExist);

                var addedSoruSecenek = new SoruSecenek
                {
                    SoruId = request.SoruId,
                    Anahtar = request.Anahtar,
                    metin = request.metin,
                    GorselUrl = request.GorselUrl,
                    DogruMu = request.DogruMu,

                };

                _soruSecenekRepository.Add(addedSoruSecenek);
                await _soruSecenekRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Added);
            }
        }
    }
}