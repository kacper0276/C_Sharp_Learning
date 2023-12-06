using ProgramowanieObiektoweCzęśćII.LINQ;
using System.Linq;

var itemList = new List<Item>
{
    new Item{ Id = Guid.NewGuid(), Name = "Product#1", Price = 100M, Quantity = 10 },
    new Item{ Id = Guid.NewGuid(), Name = "Product#4", Price = 10M, Quantity = 1 },
    new Item{ Id = Guid.NewGuid(), Name = "Product#3", Price = 500M, Quantity = 50 },
    new Item{ Id = Guid.NewGuid(), Name = "Product#2", Price = 150M, Quantity = 1000 },
};

var filteredQuantityList = from i in itemList
                           where i.Quantity > 50
                           select i;

// Równoznaczne zapisy

var filteredQuantityList2nd = itemList.Where(i => i.Quantity > 50);

var groupedList = from i in itemList
                  group i by i.Price;
var groupedList2 = itemList.GroupBy(i => i.Price);

var sortedList = from i in itemList
                 orderby i.Quantity,
                         i.Name
                 select i;

var sortedList2 = itemList.OrderBy(i => i.Quantity).ThenBy(i => i.Name);

Console.WriteLine(itemList.FirstOrDefault().Name);
Console.WriteLine(itemList.FirstOrDefault(i => i.Name.Contains("Product#1")).Name); // Jeśli nie znajdzie to null
Console.WriteLine(itemList.SingleOrDefault(i => i.Name.Contains("Product#1"))); // Jak więcej niz 1 to wyjątek
Console.WriteLine(itemList.First());
Console.WriteLine(itemList.Single(i => i.Name.Contains("Product#1")));
Console.WriteLine(itemList.Any(i => i.Name == "Product#2")); // Zwraca wartość Bool

var selectedValues = itemList.Where(i => i.Price >= 100M).Select(i => new { i.Price, i.Name }); // Obiekt anonimowy
