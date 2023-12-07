using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy
{
    class MongoRepository<T> : IRepository<T>
    {
        public Database Database => Database.Mongo;
        private readonly IMongoClient _mongoClient;

        public MongoRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }

        public void Add(T entity)
        {
            _mongoClient.Connect();
            var type = typeof(T);
            var name = GetType().Name;
            Console.WriteLine($"Adding {name} entity {type}...");
            Console.WriteLine($"Added {name} entity {type}");
        }
    }
}
