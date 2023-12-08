namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    class WłasneAtrybuty
    {
        public WłasneAtrybuty()
        {
            var item = new Item() { Id = Guid.NewGuid(), Name = "Item#1" };
            var item2 = new Item() { Id = Guid.NewGuid(), Name = "Item#2" };
            var item3 = new Item() { Id = Guid.NewGuid(), Name = "Item#3" };
            var item4 = new Item() { Id = Guid.NewGuid(), Name = "Item#4" };
            var repository = new Repository<Item>();
            var cacheableEntities = new CacheableEntities();
            var decoratedRepository = new RepositoryDecorator<Item>(repository, cacheableEntities);
            repository.Add(item);
            repository.Add(item2);
            repository.Add(item3);
            decoratedRepository.GetAll();
            decoratedRepository.Add(item4);
            decoratedRepository.GetAll();
        }
    }
}
