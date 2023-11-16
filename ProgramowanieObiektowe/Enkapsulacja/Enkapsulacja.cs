using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Enkapsulacja
{
    // Enkapsulacja to jeden z paradygmatów programowania obiektowego
    // Polega na ukryciu w obiektach pewne elementy do których użytkownik nie powinien mieć dostępu
    public class Enkapsulacja
    {
        public Enkapsulacja()
        {
            var product = new Product(1, "abc", 100);
            Console.WriteLine(nameof(product));
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
}
