using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.Ciekawostki
{
    public class UsuwanieElementowZarazPoIteracji
    {
        public UsuwanieElementowZarazPoIteracji()
        {
            List<int> a = new();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(i);
                // jak --i, najpierw i = -1, outOfRange, a i-- najpierw usunie przy 0, a potem i = -1
                a.RemoveAt(i--); // Najpierw usuwa przy indexie i = 0, potem zmiana na -1, inkrementacja i = 0, i tak ciągle
                Console.WriteLine(i);
                Console.WriteLine("----------------------------");
            }


        }
    }
}
