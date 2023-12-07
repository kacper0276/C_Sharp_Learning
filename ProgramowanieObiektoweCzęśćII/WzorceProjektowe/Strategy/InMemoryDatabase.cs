using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy
{
    public class InMemoryDatabase<T> : IRepository<T>
    {
        public Database Database => Database.InMemory;

        public void Add(T entity)
        {
            var type = typeof(T);
            var name = GetType().Name;
            Console.WriteLine($"Adding {name} entity {type}...");
            Console.WriteLine($"Added {name} entity {type}");
        }
    }
}
