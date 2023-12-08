
namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    internal class Repository<T> : IRepository<T>
    {
        private readonly Dictionary<string, IList<T>> _entries = new();

        public void Add(T entity)
        {
            var type = typeof(T);
            _entries.TryGetValue(type.Name, out var list);

            if (list is null)
            {
                list = new List<T>();
                _entries.Add(type.Name, list);
            }

            Console.WriteLine($"Add {type.Name} to Database");
            list.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            _entries.TryGetValue(typeof(T).Name, out var list);
            Console.WriteLine("Hit Database");
            return list ?? new List<T>();
        }
    }
}
