using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa
{
    public class NullableNauka
    {
        public NullableNauka()
        {
            // Nullable
            int? nul = null; // ? - zmienna typu wartościowego może mieć typ null, inaczej nie może
            if (nul.HasValue)
            {
                Console.WriteLine(nul.Value);
                Console.WriteLine(nul.GetValueOrDefault()); // W przypadku int to 0, gdy wartość to null
                                                            //  nul.HasValue; // if nul != null
                                                            //  nul.Value; // Błąd bo wartość nie może być null
                                                            //  Typy referencyjne umożliwiwają wartość null
            }
        }
    }
}
