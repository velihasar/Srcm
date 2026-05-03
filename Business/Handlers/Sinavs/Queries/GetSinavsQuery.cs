
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

namespace Business.Handlers.Sinavs.Queries
{

    public class GetSinavsQuery : IRequest<IDataResult<IEnumerable<Sinav>>>
    {
        public class GetSinavsQueryHandler : IRequestHandler<GetSinavsQuery, IDataResult<IEnumerable<Sinav>>>
        {
            private readonly ISinavRepository _sinavRepository;
            private readonly IMediator _mediator;

            public GetSinavsQueryHandler(ISinavRepository sinavRepository, IMediator mediator)
            {
                _sinavRepository = sinavRepository;
                _mediator = mediator;
            }

            [PerformanceAspect(5)]
            [CacheAspect(10)]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<IEnumerable<Sinav>>> Handle(GetSinavsQuery request, CancellationToken cancellationToken)
            {
                var list = await _sinavRepository.FindAllAsync(
                    include: q => q.Include(s => s.Bolumler.OrderBy(b => b.SiraNo))
                        .ThenInclude(b => b.Konular.OrderBy(k => k.SiraNo))
                        .ThenInclude(k => k.Sorular.OrderBy(so => so.SiraNo))
                        .ThenInclude(so => so.Secenekler.OrderBy(se => se.Id)));
                return new SuccessDataResult<IEnumerable<Sinav>>(list);
            }
        }
    }
}