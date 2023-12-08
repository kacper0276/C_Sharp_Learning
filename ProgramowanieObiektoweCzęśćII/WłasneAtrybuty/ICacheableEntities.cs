using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    internal interface ICacheableEntities
    {
        IEnumerable<Type> GetCacheableEntities();
    }
}
