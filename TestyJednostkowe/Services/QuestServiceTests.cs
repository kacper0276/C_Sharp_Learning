using Moq;
using TodoApp.Core.Services;
using TodoApp.Core.Repositories;
using TodoApp.Core.Entities;
using TodoApp.Core.DTO;

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
