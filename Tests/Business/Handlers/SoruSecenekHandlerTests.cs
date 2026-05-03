
using Business.Handlers.SoruSeceneks.Queries;
using DataAccess.Abstract;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static Business.Handlers.SoruSeceneks.Queries.GetSoruSecenekQuery;
using Entities.Concrete;
using static Business.Handlers.SoruSeceneks.Queries.GetSoruSeceneksQuery;
using static Business.Handlers.SoruSeceneks.Commands.CreateSoruSecenekCommand;
using Business.Handlers.SoruSeceneks.Commands;
using Business.Constants;
using static Business.Handlers.SoruSeceneks.Commands.UpdateSoruSecenekCommand;
using static Business.Handlers.SoruSeceneks.Commands.DeleteSoruSecenekCommand;
using MediatR;
using System.Linq;
using FluentAssertions;
using Core.Entities.Concrete.Project;


namespace Tests.Business.HandlersTest
{
    [TestFixture]
    public class SoruSecenekHandlerTests
    {
        Mock<ISoruSecenekRepository> _soruSecenekRepository;
        Mock<IMediator> _mediator;
        [SetUp]
        public void Setup()
        {
            _soruSecenekRepository = new Mock<ISoruSecenekRepository>();
            _mediator = new Mock<IMediator>();
        }

        [Test]
        public async Task SoruSecenek_GetQuery_Success()
        {
            //Arrange
            var query = new GetSoruSecenekQuery();

            _soruSecenekRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<SoruSecenek, bool>>>())).ReturnsAsync(new SoruSecenek()
//propertyler buraya yazılacak
//{																		
//SoruSecenekId = 1,
//SoruSecenekName = "Test"
//}
);

            var handler = new GetSoruSecenekQueryHandler(_soruSecenekRepository.Object, _mediator.Object);

            //Act
            var x = await handler.Handle(query, new System.Threading.CancellationToken());

            //Asset
            x.Success.Should().BeTrue();
            //x.Data.SoruSecenekId.Should().Be(1);

        }

        [Test]
        public async Task SoruSecenek_GetQueries_Success()
        {
            //Arrange
            var query = new GetSoruSeceneksQuery();

            _soruSecenekRepository.Setup(x => x.GetListAsync(It.IsAny<Expression<Func<SoruSecenek, bool>>>()))
                        .ReturnsAsync(new List<SoruSecenek> { new SoruSecenek() { /*TODO:propertyler buraya yazılacak SoruSecenekId = 1, SoruSecenekName = "test"*/ } });

            var handler = new GetSoruSeceneksQueryHandler(_soruSecenekRepository.Object, _mediator.Object);

            //Act
            var x = await handler.Handle(query, new System.Threading.CancellationToken());

            //Asset
            x.Success.Should().BeTrue();
            ((List<SoruSecenek>)x.Data).Count.Should().BeGreaterThan(1);

        }

        [Test]
        public async Task SoruSecenek_CreateCommand_Success()
        {
            SoruSecenek rt = null;
            //Arrange
            var command = new CreateSoruSecenekCommand();
            //propertyler buraya yazılacak
            //command.SoruSecenekName = "deneme";

            _soruSecenekRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<SoruSecenek, bool>>>()))
                        .ReturnsAsync(rt);

            _soruSecenekRepository.Setup(x => x.Add(It.IsAny<SoruSecenek>())).Returns(new SoruSecenek());

            var handler = new CreateSoruSecenekCommandHandler(_soruSecenekRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _soruSecenekRepository.Verify(x => x.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Added);
        }

        [Test]
        public async Task SoruSecenek_CreateCommand_NameAlreadyExist()
        {
            //Arrange
            var command = new CreateSoruSecenekCommand();
            //propertyler buraya yazılacak 
            //command.SoruSecenekName = "test";

            _soruSecenekRepository.Setup(x => x.Query())
                                           .Returns(new List<SoruSecenek> { new SoruSecenek() { /*TODO:propertyler buraya yazılacak SoruSecenekId = 1, SoruSecenekName = "test"*/ } }.AsQueryable());

            _soruSecenekRepository.Setup(x => x.Add(It.IsAny<SoruSecenek>())).Returns(new SoruSecenek());

            var handler = new CreateSoruSecenekCommandHandler(_soruSecenekRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            x.Success.Should().BeFalse();
            x.Message.Should().Be(Messages.NameAlreadyExist);
        }

        [Test]
        public async Task SoruSecenek_UpdateCommand_Success()
        {
            //Arrange
            var command = new UpdateSoruSecenekCommand();
            //command.SoruSecenekName = "test";

            _soruSecenekRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<SoruSecenek, bool>>>()))
                        .ReturnsAsync(new SoruSecenek() { /*TODO:propertyler buraya yazılacak SoruSecenekId = 1, SoruSecenekName = "deneme"*/ });

            _soruSecenekRepository.Setup(x => x.Update(It.IsAny<SoruSecenek>())).Returns(new SoruSecenek());

            var handler = new UpdateSoruSecenekCommandHandler(_soruSecenekRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _soruSecenekRepository.Verify(x => x.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Updated);
        }

        [Test]
        public async Task SoruSecenek_DeleteCommand_Success()
        {
            //Arrange
            var command = new DeleteSoruSecenekCommand();

            _soruSecenekRepository.Setup(x => x.GetAsync(It.IsAny<Expression<Func<SoruSecenek, bool>>>()))
                        .ReturnsAsync(new SoruSecenek() { /*TODO:propertyler buraya yazılacak SoruSecenekId = 1, SoruSecenekName = "deneme"*/});

            _soruSecenekRepository.Setup(x => x.Delete(It.IsAny<SoruSecenek>()));

            var handler = new DeleteSoruSecenekCommandHandler(_soruSecenekRepository.Object, _mediator.Object);
            var x = await handler.Handle(command, new System.Threading.CancellationToken());

            _soruSecenekRepository.Verify(x => x.SaveChangesAsync());
            x.Success.Should().BeTrue();
            x.Message.Should().Be(Messages.Deleted);
        }
    }
}

