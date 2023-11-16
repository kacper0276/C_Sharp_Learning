using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.TworzenieObiektow
{
    public class TworzenieObiektow
    {
        public TworzenieObiektow()
        {
            Price price = Price.Create(15);

            Price price1 = Price.Create(10);

            Console.WriteLine(price * price1);
            Console.WriteLine(price + price1);
            Console.WriteLine(price - price1);
            Console.WriteLine(price / price1);
            Console.WriteLine(price == price1);
            Console.WriteLine(price != price1);
        }
    }
}
