using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Solid
{
    internal class NonRelationDbClient : IDbClient
    {
        public T? Query<T>(string query)
        {
            Console.WriteLine(query);
            return default;
        }
    }
}
