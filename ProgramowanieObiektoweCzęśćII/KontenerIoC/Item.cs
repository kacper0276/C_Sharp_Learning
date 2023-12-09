namespace ProgramowanieObiektoweCzęśćII.KontenerIoC
{
    class Item
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; } = nameof(Item);
    }
}
