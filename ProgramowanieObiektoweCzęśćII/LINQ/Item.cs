using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.LINQ
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = nameof(Item);
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
