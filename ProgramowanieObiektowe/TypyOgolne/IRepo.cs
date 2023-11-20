namespace ProgramowanieObiektowe.TypyOgolne
{
    public interface IRepo<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        TPrimaryKey Add(TEntity entity);
        TEntity? Get<T>(TPrimaryKey key)
            where T : class, IEntity<TPrimaryKey>;
    }
}
