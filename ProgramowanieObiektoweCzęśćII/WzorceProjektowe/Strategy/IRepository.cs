using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy
{
    public interface IRepository<T>
    {
        public Database Database { get; }
        void Add(T entity);
    }
}
