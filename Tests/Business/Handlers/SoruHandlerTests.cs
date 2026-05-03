
using Business.Handlers.Sorus.Queries;
using DataAccess.Abstract;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static Business.Handlers.Sorus.Queries.GetSoruQuery;
using Entities.Concrete;
using static Business.Handlers.Sorus.Queries.GetSorusQuery;
using static Business.Handlers.Sorus.Commands.CreateSoruCommand;
using Business.Handlers.Sorus.Commands;
using Business.Constants;
using static Business.Handlers.Sorus.Commands.UpdateSoruCommand;
using static Business.Handlers.Sorus.Commands.DeleteSoruCommand;
using MediatR;
using System.Linq;
using FluentAssertions;
using Core.Entities.Concrete.Project;


namespace Tests.Business.HandlersTest
{
    [TestFixture]
    public class SoruHandlerTests
    {
        Mock<ISoruRepository> _soruRepository;
        Mock<IMediator> _mediator;
        [SetUp]
        public void Setup()
        {
            _soruRepository = new Mock<ISoruRepository>();
            _mediator = new Mock<IMediator>();
        }

        [Test]
        public async Task Soru_GetQuery_Success()
        {
            //Arrange
            var query = new GetSoruQuery();

            _soruRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Soru, bool>>>())).ReturnsAsync(new Soru()
//propertyler buraya yazılacak
//{																		
//SoruId = 1,
//SoruName = "Test"
//}
);

            var handler = new GetSoruQueryHandler(_soruRepository.Object, _mediator.Object);

            //Act
            var x = await handler.Handle(query, new System.Threading.CancellationToken());

            //Asset
            x.Success.Should().BeTrue();
            //x.Data.SoruId.Should().Be(1);

        }

        [Test]
        public async Task Soru_GetQueries_Success()
        {
            //Arrange
            var query = new GetSorusQuery();

            _soruRepository.Setup(x => x.GetListAsync(It.IsAny<Expression<Func<Soru, bool>>>()))
                        .ReturnsAsync(new List<Soru> { new Soru() { /*TODO:propertyler buraya yazılacak SoruId = 1, SoruName = "test"*/ } });

            var handler = new GetSorusQueryHandler(_soruRepository.Object, _mediator.Object);

            //Act
            var x = await handler.Handle(query, new System.Threading.CancellationToken());

            //Asset
            x.Success.Should().BeTrue();
            ((List<Soru>)x.Data).Count.Should().BeGreaterThan(1);

        }

        [Test]
        public async Task Soru_CreateCommand_Success()
        {
            Soru rt = null;
            //Arrange
            var command = new CreateSoruCommand();
            //propertyler buraya yazılacak
            //command.SoruName = "deneme";

            _soruRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Soru, bool>>>()))
                        .ReturnsAsync(rt);

            _soruRepository.Setup(x => x.Add(It.IsAny<Soru>())).Returns(new Soru());

            var handler = new CreateSoruCommandHandler(_soruRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _soruRepository.Verify(x => x.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Added);
        }

        [Test]
        public async Task Soru_CreateCommand_NameAlreadyExist()
        {
            //Arrange
            var command = new CreateSoruCommand();
            //propertyler buraya yazılacak 
            //command.SoruName = "test";

            _soruRepository.Setup(x => x.Query())
                                           .Returns(new List<Soru> { new Soru() { /*TODO:propertyler buraya yazılacak SoruId = 1, SoruName = "test"*/ } }.AsQueryable());

            _soruRepository.Setup(x => x.Add(It.IsAny<Soru>())).Returns(new Soru());

            var handler = new CreateSoruCommandHandler(_soruRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            x.Success.Should().BeFalse();
            x.Message.Should().Be(Messages.NameAlreadyExist);
        }

        [Test]
        public async Task Soru_UpdateCommand_Success()
        {
            //Arrange
            var command = new UpdateSoruCommand();
            //command.SoruName = "test";

            _soruRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Soru, bool>>>()))
                        .ReturnsAsync(new Soru() { /*TODO:propertyler buraya yazılacak SoruId = 1, SoruName = "deneme"*/ });

            _soruRepository.Setup(x => x.Update(It.IsAny<Soru>())).Returns(new Soru());

            var handler = new UpdateSoruCommandHandler(_soruRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _soruRepository.Verify(x => x.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Updated);
        }

        [Test]
        public async Task Soru_DeleteCommand_Success()
        {
            //Arrange
            var command = new DeleteSoruCommand();

            _soruRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Soru, bool>>>()))
                        .ReturnsAsync(new Soru() { /*TODO:propertyler buraya yazılacak SoruId = 1, SoruName = "deneme"*/});

            _soruRepository.Setup(x => x.Delete(It.IsAny<Soru>()));

            var handler = new DeleteSoruCommandHandler(_soruRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _soruRepository.Verify(x => x.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Deleted);
        }
    }
}

