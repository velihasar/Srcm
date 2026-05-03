
using Business.BusinessAspects;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using System.Linq;
using Core.Entities.Concrete.Project;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Sorus.Queries
{
    public class GetSoruQuery : IRequest<IDataResult<Soru>>
    {
        public int Id { get; set; }

        public class GetSoruQueryHandler : IRequestHandler<GetSoruQuery, IDataResult<Soru>>
        {
            private readonly ISoruRepository _soruRepository;
            private readonly IMediator _mediator;

            public GetSoruQueryHandler(ISoruRepository soruRepository, IMediator mediator)
            {
                _soruRepository = soruRepository;
                _mediator = mediator;
            }
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<Soru>> Handle(GetSoruQuery request, CancellationToken cancellationToken)
            {
                var soru = await _soruRepository.GetWithIncludeAsync(
                    p => p.Id == request.Id,
                    q => q.Include(s => s.Secenekler.OrderBy(se => se.Id)));
                return new SuccessDataResult<Soru>(soru);
            }
        }
    }
}
