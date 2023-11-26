using Shouldly;
using TodoApp.Core.Entities;
using TodoApp.Core.Exceptions;

namespace TestyJednostkowe.Entities
{
    public class QuestTests
    {
        [Fact]
        public void should_create_quest()
        {
            // Snake case - test_with_sth
            // Camel case - camelCase
            // Pascal case - PascalCase

            // Arrange inaczej given
            var title = "Quest#1";
            var description = "";
            var beforeCreated = DateTime.UtcNow;

            // Act inaczej when
            var quest = Quest.Create(title, description);

            // Assert inaczej then
            var afterCreated = DateTime.UtcNow;
            quest.ShouldNotBeNull();
            quest.Title.ShouldBe(title);
            quest.Description.ShouldBe(description);
            quest.Status.ShouldBe(QuestStatus.New);
            quest.Modified.ShouldBeNull();
            quest.Created.ShouldBeGreaterThan(beforeCreated);
            quest.Created.ShouldBeLessThan(afterCreated);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("       ")]
        [InlineData("a")]
        public void given_invalid_title_when_create_quest_should_be_throw_an_exception(string title)
        {
            // Arrange inaczej given
            var description = "";

            // Act inaczej when
            var exception = Record.Exception(() => Quest.Create(title, description));

            // Assert inaczej then
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<CustomException>();
            exception.Message.ShouldContain("Title");
            
        }
    }
}