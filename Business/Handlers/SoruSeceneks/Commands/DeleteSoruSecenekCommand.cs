
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


namespace Business.Handlers.SoruSeceneks.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteSoruSecenekCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class DeleteSoruSecenekCommandHandler : IRequestHandler<DeleteSoruSecenekCommand, IResult>
        {
            private readonly ISoruSecenekRepository _soruSecenekRepository;
            private readonly IMediator _mediator;

            public DeleteSoruSecenekCommandHandler(ISoruSecenekRepository soruSecenekRepository, IMediator mediator)
            {
                _soruSecenekRepository = soruSecenekRepository;
                _mediator = mediator;
            }

            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(DeleteSoruSecenekCommand request, CancellationToken cancellationToken)
            {
                var soruSecenekToDelete = _soruSecenekRepository.Get(p => p.Id == request.Id);

                _soruSecenekRepository.Delete(soruSecenekToDelete);
                await _soruSecenekRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Deleted);
            }
        }
    }
}

