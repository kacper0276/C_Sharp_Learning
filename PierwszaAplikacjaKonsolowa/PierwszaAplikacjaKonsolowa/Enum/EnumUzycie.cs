using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.Enum
{
    public class EnumUzycie
    {
        public EnumUzycie()
        {
            // Enum
            Priority priority = Priority.High;
            Console.WriteLine(priority);
            Console.WriteLine((int)priority);
        }
    }
}
