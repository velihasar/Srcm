
using Business.BusinessAspects;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Entities.Concrete.Project;


namespace Business.Handlers.SoruSeceneks.Queries
{
    public class GetSoruSecenekQuery : IRequest<IDataResult<SoruSecenek>>
    {
        public int Id { get; set; }

        public class GetSoruSecenekQueryHandler : IRequestHandler<GetSoruSecenekQuery, IDataResult<SoruSecenek>>
        {
            private readonly ISoruSecenekRepository _soruSecenekRepository;
            private readonly IMediator _mediator;

            public GetSoruSecenekQueryHandler(ISoruSecenekRepository soruSecenekRepository, IMediator mediator)
            {
                _soruSecenekRepository = soruSecenekRepository;
                _mediator = mediator;
            }
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<SoruSecenek>> Handle(GetSoruSecenekQuery request, CancellationToken cancellationToken)
            {
                var soruSecenek = await _soruSecenekRepository.GetAsync(p => p.Id == request.Id);
                return new SuccessDataResult<SoruSecenek>(soruSecenek);
            }
        }
    }
}
