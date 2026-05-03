
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

namespace Business.Handlers.Bolums.Queries
{

    public class GetBolumsQuery : IRequest<IDataResult<IEnumerable<Bolum>>>
    {
        public class GetBolumsQueryHandler : IRequestHandler<GetBolumsQuery, IDataResult<IEnumerable<Bolum>>>
        {
            private readonly IBolumRepository _bolumRepository;
            private readonly IMediator _mediator;

            public GetBolumsQueryHandler(IBolumRepository bolumRepository, IMediator mediator)
            {
                _bolumRepository = bolumRepository;
                _mediator = mediator;
            }

            [PerformanceAspect(5)]
            [CacheAspect(10)]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<IEnumerable<Bolum>>> Handle(GetBolumsQuery request, CancellationToken cancellationToken)
            {
                var list = await _bolumRepository.FindAllAsync(
                    include: q => q.Include(b => b.Konular.OrderBy(k => k.SiraNo))
                        .ThenInclude(k => k.Sorular.OrderBy(so => so.SiraNo))
                        .ThenInclude(so => so.Secenekler.OrderBy(se => se.Id)));
                return new SuccessDataResult<IEnumerable<Bolum>>(list);
            }
        }
    }
}