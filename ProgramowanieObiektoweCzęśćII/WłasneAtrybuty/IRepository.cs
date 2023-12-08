namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    interface IRepository<T>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
    }
}
