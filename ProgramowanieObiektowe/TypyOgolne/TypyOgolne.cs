using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.TypyOgolne
{
    public class TypyOgolne // - Typy Generyczne
    {
        public TypyOgolne()
        {
            var repository = new Repository<IEntity<int>, int>();
            repository.Add(new Product { Id = 1, Name = "Product 1" });
            repository.Add(new Product { Id = 2, Name = "Product 2" });
            repository.Add(new Product { Id = 3, Name = "Product 3" });

            Console.WriteLine(repository.Get<Drink>(20)?.Id.ToString() ?? "null drink");
            Console.WriteLine(repository.Get<Drink>(1)?.Id.ToString() ?? "null drink");
            Console.WriteLine(repository.Get<Product>(2)?.Id.ToString() ?? "null product");
        }
    }
}
