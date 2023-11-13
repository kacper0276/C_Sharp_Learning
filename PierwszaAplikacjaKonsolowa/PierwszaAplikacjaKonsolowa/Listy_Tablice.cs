using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa
{
    public class Listy_Tablice
    {
        public Listy_Tablice()
        {
            // Listy i Tablice
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Array.IndexOf(arr, 5)); // Zwraca index wartości - 4
            Array.Sort(arr);

            List<int> arr2 = new List<int>();
            arr2.Add(5);


            arr2.Sort();
            arr2.AddRange(new List<int> { 5, 2, 1 });
            arr2.RemoveRange(0, 2); // Od indexu 0 usuwa 2 elementy
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            // arr2.RemoveAll(); // Usuwa wszyskie
        }
    }
}
