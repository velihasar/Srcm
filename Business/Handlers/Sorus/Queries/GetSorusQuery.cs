
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
using System.Linq;
using Core.Entities.Concrete.Project;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Sorus.Queries
{

    public class GetSorusQuery : IRequest<IDataResult<IEnumerable<Soru>>>
    {
        public class GetSorusQueryHandler : IRequestHandler<GetSorusQuery, IDataResult<IEnumerable<Soru>>>
        {
            private readonly ISoruRepository _soruRepository;
            private readonly IMediator _mediator;

            public GetSorusQueryHandler(ISoruRepository soruRepository, IMediator mediator)
            {
                _soruRepository = soruRepository;
                _mediator = mediator;
            }

            [PerformanceAspect(5)]
            [CacheAspect(10)]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<IEnumerable<Soru>>> Handle(GetSorusQuery request, CancellationToken cancellationToken)
            {
                var list = await _soruRepository.FindAllAsync(
                    include: q => q.Include(s => s.Secenekler.OrderBy(se => se.Id)));
                return new SuccessDataResult<IEnumerable<Soru>>(list);
            }
        }
    }
}