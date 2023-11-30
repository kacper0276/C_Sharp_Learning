﻿using Moq;
using TodoApp.Core.Services;
using TodoApp.Core.Repositories;
using TodoApp.Core.Entities;
using TodoApp.Core.DTO;
using Shouldly;
using TodoApp.Core.Exceptions;

namespace TestyJednostkowe.Services
{
    public class QuestServiceTests
    {
        private readonly IQuestService _questService;
        private readonly Mock<IRepository<Quest>> _repository;

        public QuestServiceTests()
        {
            _repository = new Mock<IRepository<Quest>>();
            _questService = new QuestService(_repository.Object);
        }

        [Fact]
        public void should_add_quest()
        {
            var dto = new QuestDto() { Title = "Title#1" };

            _questService.AddQuest(dto);

            _repository.Verify(r => r.Add(It.IsAny<Quest>()), times: Times.Once);
        }

        [Fact]
        public void should_quest_status()
        {
            var quest = CreatedDefaultQuest();
            _repository.Setup(r => r.Get(quest.Id)).Returns(quest);
            var status = QuestStatus.Complete.ToString();

            var questAfterUpdate = _questService.ChangeQuestStatus(quest.Id, status);

            questAfterUpdate.ShouldNotBeNull();
            _repository.Verify(r => r.Update(quest));
            questAfterUpdate.Status.ShouldBe(status);
        }

        [Fact]
        public void given_invalid_id_when_change_quest_status_should_throw_an_exception()
        {
            var id = 1;
            var status = "abc";
            // FluentAssertion
            var exception = Record.Exception(() => _questService.ChangeQuestStatus(id, status));
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<CustomException>();
            exception.Message.ShouldContain("Not found");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("         ")]
        [InlineData("nie+istnieje")]
        [InlineData("200")]
        public void given_invalid_status_when_change_quest_status_should_throw_an_exception(string status)
        {
            var quest = CreatedDefaultQuest();
            _repository.Setup(r => r.Get(quest.Id)).Returns(quest);

            var expectedException = new CustomException($"There is no Quest status {status}");
            // FluentAssertion
            var exception = Record.Exception(() => _questService.ChangeQuestStatus(quest.Id, status));
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType(expectedException.GetType());
            exception.Message.ShouldBe(expectedException.Message);
        }

        public static Quest CreatedDefaultQuest(int id = 1, string? title = null, string? description = null, QuestStatus questStatus = QuestStatus.New)
        {
            return new Quest(id, 
                title ?? $"Title#{Guid.NewGuid().ToString("N")}", 
                description ?? "", 
                QuestStatus.New, 
                DateTime.UtcNow);
        }

        [Fact]
        public void Test()
        {
            //var mockRepo = new Mock<Repository<Quest>>();
            //var mockService = new Mock<QuestService>(mockRepo.Object);
            //var service = mockService.Object;
            //service.DeleteQuest(1);
            var mockService = new Mock<IQuestService>();
            mockService.Object.DeleteQuest(1);
            mockService.Verify(a => a.DeleteQuest(1), Times.Once);
        }
    }
}
