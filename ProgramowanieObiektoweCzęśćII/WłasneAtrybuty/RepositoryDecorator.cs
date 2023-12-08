namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    internal class RepositoryDecorator<T> : IRepository<T>
    {
        private readonly IRepository<T> _repository;
        private readonly ICacheableEntities _cacheableEntities;
        private readonly IDictionary<Type, IList<T>> _entitiesCached = new Dictionary<Type, IList<T>>();

        public RepositoryDecorator(IRepository<T> repository, ICacheableEntities cacheableEntities)
        {
            _repository = repository;
            _cacheableEntities = cacheableEntities;
        }

        public void Add(T item)
        {
            if (!IsCached())
            {
                _repository.Add(item);
            }

            var type = typeof(T);
            _entitiesCached.TryGetValue(type, out var list);

            if (list is null)
            {
                list = _repository.GetAll().ToList();
                _entitiesCached.Add(type, list);
            }

            _repository.Add(item);
            Console.WriteLine("Update Cache");
            list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            if (!IsCached())
            {
                return _repository.GetAll();
            }

            Console.WriteLine("Hit Cache");
            var type = typeof(T);
            _entitiesCached.TryGetValue(type, out var list);

            if (list is null)
            {
                list = _repository.GetAll().ToList();
                _entitiesCached.Add(type, list);
            }

            return list;
        }

        private bool IsCached()
        {
            return _cacheableEntities.GetCacheableEntities()
                .ToList()
                .Any(t => typeof(T) == t);
        }
    }
}
