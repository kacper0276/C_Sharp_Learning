
namespace ProgramowanieObiektoweCzęśćII.KontenerIoC
{
    class ItemService : IItemService
    {
        private readonly List<Item> _items = new();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public bool DeleteItem(Guid id)
        {
            var item = _items.SingleOrDefault(i => i.Id == id);

            if(item is null)
            {
                return false;
            }

            return true;
        }
    }
}
