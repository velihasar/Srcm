
using Business.BusinessAspects;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Aspects.Autofac.Caching;
using Core.Entities.Concrete.Project;

namespace Business.Handlers.SoruSeceneks.Queries
{

    public class GetSoruSeceneksQuery : IRequest<IDataResult<IEnumerable<SoruSecenek>>>
    {
        public class GetSoruSeceneksQueryHandler : IRequestHandler<GetSoruSeceneksQuery, IDataResult<IEnumerable<SoruSecenek>>>
        {
            private readonly ISoruSecenekRepository _soruSecenekRepository;
            private readonly IMediator _mediator;

            public GetSoruSeceneksQueryHandler(ISoruSecenekRepository soruSecenekRepository, IMediator mediator)
            {
                _soruSecenekRepository = soruSecenekRepository;
                _mediator = mediator;
            }

            [PerformanceAspect(5)]
            [CacheAspect(10)]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<IEnumerable<SoruSecenek>>> Handle(GetSoruSeceneksQuery request, CancellationToken cancellationToken)
            {
                return new SuccessDataResult<IEnumerable<SoruSecenek>>(await _soruSecenekRepository.GetListAsync());
            }
        }
    }
}