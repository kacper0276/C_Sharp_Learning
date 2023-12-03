using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entities;

namespace TestyJednostkowe.Common
{
    internal static class Fixture
    {

        public static Quest CreatedDefaultQuest(int id = 1, string? title = null, string? description = null, QuestStatus questStatus = QuestStatus.New)
        {
            return new Quest(id,
                title ?? $"Title#{Guid.NewGuid().ToString("N")}",
                description ?? "",
                QuestStatus.New,
                DateTime.UtcNow);
        }
    }
}
