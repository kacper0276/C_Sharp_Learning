using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.Podstawy
{
    public class InstrukcjeWarunkowe
    {
        public InstrukcjeWarunkowe()
        {

            int firstNumber = 1;

            int aa = 5;
            int b = aa == 5 ? 10 : 5;

            switch (firstNumber)
            {
                case 1:
                    Console.WriteLine("First");
                    break;
                case 2:
                    Console.WriteLine("Second");
                    break;
                default:
                    Console.WriteLine("Domyślny");
                    break;
            }

            string text = firstNumber switch
            {
                1 => "Test123",
                2 => "AAA",
                _ => "Default"
            };

            int whileIt = 5;

            do
            {
                Console.WriteLine("Do " + whileIt);
            } while (whileIt-- > 0);

            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    break; // Wychodzi z pętli
                }

                if (i == 0)
                {
                    continue; // Następna iteracja
                }

                Console.WriteLine(i);
            }
            goto Test;

        Test:
            Console.WriteLine("Go To Test");

        }
    }
}
