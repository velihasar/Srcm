
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

namespace Business.Handlers.Konus.Queries
{
    public class GetKonuQuery : IRequest<IDataResult<Konu>>
    {
        public int Id { get; set; }

        public class GetKonuQueryHandler : IRequestHandler<GetKonuQuery, IDataResult<Konu>>
        {
            private readonly IKonuRepository _konuRepository;
            private readonly IMediator _mediator;

            public GetKonuQueryHandler(IKonuRepository konuRepository, IMediator mediator)
            {
                _konuRepository = konuRepository;
                _mediator = mediator;
            }
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<Konu>> Handle(GetKonuQuery request, CancellationToken cancellationToken)
            {
                var konu = await _konuRepository.GetWithIncludeAsync(
                    p => p.Id == request.Id,
                    q => q.Include(k => k.Sorular.OrderBy(so => so.SiraNo))
                        .ThenInclude(so => so.Secenekler.OrderBy(se => se.Id)));
                return new SuccessDataResult<Konu>(konu);
            }
        }
    }
}
