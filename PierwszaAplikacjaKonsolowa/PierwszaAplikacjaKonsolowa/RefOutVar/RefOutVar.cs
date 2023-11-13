using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.RefOutVar
{
    public class RefOutVar
    {
        public RefOutVar()
        {
            static void SetTwoRef(ref int i) // Przekazuje referencje a nie sama wartosc
            {
                i = 2;
            }

            static void SetTwoOut(out int i)
            {
                i = 2;
            }

            int number = 0;
            SetTwoRef(ref number);
            Console.WriteLine(number);

            // int number2; -> wtedy SetTwoOut(out number2) 
            SetTwoOut(out int number2);
            Console.WriteLine(number2);

            // Var - sam typuje rodzaj zmiennej
            var a = 10;
        }
    }
}
