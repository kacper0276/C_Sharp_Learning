using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy
{
    class RepositoryManager<T>
    {
        private readonly IEnumerable<IRepository<T>> _repositories;

        public RepositoryManager(IEnumerable<IRepository<T>> repositories)
        {
            _repositories = repositories;
        }

        public IRepository<T> GetRepository(Database database)
        {
            return database switch
            {
                Database.InMemory => _repositories.SingleOrDefault(r => r.Database == Database.InMemory) ?? throw new ArgumentException("Not found implementation"),
                Database.Mongo => _repositories.SingleOrDefault(r => r.Database == Database.Mongo) ?? throw new ArgumentException("Not found implementation"),
                _ => throw new ArgumentException("Not found implementation")
            };
        }
    }
}
