
using Business.BusinessAspects;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos.SinavDto;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Aspects.Autofac.Caching;
using System.Linq;
using Business.Handlers.Sinavs;

namespace Business.Handlers.Sinavs.Queries
{
    public class GetSinavsQuery : IRequest<IDataResult<IEnumerable<SinavDto>>>
    {
        public class GetSinavsQueryHandler : IRequestHandler<GetSinavsQuery, IDataResult<IEnumerable<SinavDto>>>
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
            public async Task<IDataResult<IEnumerable<SinavDto>>> Handle(GetSinavsQuery request, CancellationToken cancellationToken)
            {
                var list = await _sinavRepository.GetListAsync();
                var dtoList = list.Select(SinavDtoMapper.ToDto).ToList();
                return new SuccessDataResult<IEnumerable<SinavDto>>(dtoList);
            }
        }
    }
}
