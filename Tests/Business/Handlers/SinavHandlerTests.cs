
using Business.Handlers.Sinavs.Queries;
using DataAccess.Abstract;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static Business.Handlers.Sinavs.Queries.GetSinavQuery;
using static Business.Handlers.Sinavs.Queries.GetSinavsQuery;
using static Business.Handlers.Sinavs.Commands.CreateSinavCommand;
using Business.Handlers.Sinavs.Commands;
using Business.Constants;
using static Business.Handlers.Sinavs.Commands.UpdateSinavCommand;
using static Business.Handlers.Sinavs.Commands.DeleteSinavCommand;
using MediatR;
using System.Linq;
using FluentAssertions;
using Core.Entities.Concrete.Project;

namespace Tests.Business.HandlersTest
{
    [TestFixture]
    public class SinavHandlerTests
    {
        Mock<ISinavRepository> _sinavRepository;
        Mock<IMediator> _mediator;

        [SetUp]
        public void Setup()
        {
            _sinavRepository = new Mock<ISinavRepository>();
            _mediator = new Mock<IMediator>();
        }

        [Test]
        public async Task Sinav_GetQuery_Success()
        {
            var query = new GetSinavQuery { Id = 1 };

            _sinavRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Sinav, bool>>>()))
                .ReturnsAsync(new Sinav { Id = 1, KisaAd = "T", Ad = "Test", SiraNo = 1 });

            var handler = new GetSinavQueryHandler(_sinavRepository.Object, _mediator.Object);

            var x = await handler.Handle(query, new System.Threading.CancellationToken());

            x.Success.Should().BeTrue();
            x.Data.Should().NotBeNull();
            x.Data.Id.Should().Be(1);
            x.Data.KisaAd.Should().Be("T");
        }

        [Test]
        public async Task Sinav_GetQueries_Success()
        {
            var query = new GetSinavsQuery();

            _sinavRepository.Setup(x => x.GetListAsync(It.IsAny<Expression<Func<Sinav, bool>>>()))
                .ReturnsAsync(new List<Sinav>
                {
                    new Sinav { Id = 1, KisaAd = "A", Ad = "a", SiraNo = 1 },
                    new Sinav { Id = 2, KisaAd = "B", Ad = "b", SiraNo = 2 }
                });

            var handler = new GetSinavsQueryHandler(_sinavRepository.Object, _mediator.Object);

            var x = await handler.Handle(query, new System.Threading.CancellationToken());

            x.Success.Should().BeTrue();
            x.Data.Should().HaveCount(2);
        }

        [Test]
        public async Task Sinav_CreateCommand_Success()
        {
            var command = new CreateSinavCommand { KisaAd = "x", Ad = "y", SiraNo = 1 };

            _sinavRepository.Setup(x => x.Query())
                .Returns(new List<Sinav>().AsQueryable());

            _sinavRepository.Setup(x => x.Add(It.IsAny<Sinav>())).Returns(new Sinav());

            var handler = new CreateSinavCommandHandler(_sinavRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _sinavRepository.Verify(v => v.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Added);
        }

        [Test]
        public async Task Sinav_CreateCommand_NameAlreadyExist()
        {
            var command = new CreateSinavCommand { KisaAd = "dup", Ad = "y", SiraNo = 1 };

            _sinavRepository.Setup(x => x.Query())
                .Returns(new List<Sinav> { new Sinav { KisaAd = "dup" } }.AsQueryable());

            _sinavRepository.Setup(x => x.Add(It.IsAny<Sinav>())).Returns(new Sinav());

            var handler = new CreateSinavCommandHandler(_sinavRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            x.Success.Should().BeFalse();
            x.Message.Should().Be(Messages.NameAlreadyExist);
        }

        [Test]
        public async Task Sinav_UpdateCommand_Success()
        {
            var command = new UpdateSinavCommand { Id = 1, KisaAd = "u", Ad = "u2", SiraNo = 2 };

            _sinavRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Sinav, bool>>>()))
                .ReturnsAsync(new Sinav { Id = 1, KisaAd = "old", Ad = "old2", SiraNo = 1 });

            _sinavRepository.Setup(x => x.Update(It.IsAny<Sinav>())).Returns(new Sinav());

            var handler = new UpdateSinavCommandHandler(_sinavRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _sinavRepository.Verify(v => v.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Updated);
        }

        [Test]
        public async Task Sinav_DeleteCommand_Success()
        {
            var command = new DeleteSinavCommand { Id = 1 };

            _sinavRepository.Setup(x => x.Get(It.IsAny<Expression<Func<Sinav, bool>>>()))
                .Returns(new Sinav { Id = 1 });

            _sinavRepository.Setup(x => x.Delete(It.IsAny<Sinav>()));

            var handler = new DeleteSinavCommandHandler(_sinavRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _sinavRepository.Verify(v => v.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Deleted);
        }
    }
}
