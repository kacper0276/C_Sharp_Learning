namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    [Cacheable]
    class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = nameof(Item);
    }
}
