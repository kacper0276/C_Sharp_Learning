using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    internal class CacheableEntities : ICacheableEntities
    {
        private readonly IList<Type> _cacheableEntities = new List<Type>();

        public CacheableEntities()
        {
            var assembly = Assembly.GetExecutingAssembly();
            _cacheableEntities = assembly.GetTypes()
                .Where(type => Attribute.IsDefined(type, typeof(Cacheable))).ToList();
        }

        public IEnumerable<Type> GetCacheableEntities()
        {
            return _cacheableEntities;
        }
    }
}
