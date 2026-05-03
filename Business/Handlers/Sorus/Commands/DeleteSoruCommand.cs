
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace Business.Handlers.Sorus.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteSoruCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class DeleteSoruCommandHandler : IRequestHandler<DeleteSoruCommand, IResult>
        {
            private readonly ISoruRepository _soruRepository;
            private readonly IMediator _mediator;

            public DeleteSoruCommandHandler(ISoruRepository soruRepository, IMediator mediator)
            {
                _soruRepository = soruRepository;
                _mediator = mediator;
            }

            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(DeleteSoruCommand request, CancellationToken cancellationToken)
            {
                var soruToDelete = _soruRepository.Get(p => p.Id == request.Id);

                _soruRepository.Delete(soruToDelete);
                await _soruRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Deleted);
            }
        }
    }
}

