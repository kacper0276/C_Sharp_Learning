using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacjaKonsolowa.ObslugaWyjatkow
{
    public class ObslugaWyjatkow
    {
        public ObslugaWyjatkow()
        {
            static void ThrowException(int id)
            {
                if (id == 0)
                {
                    throw new ArgumentNullException("id");
                }
            }

            try
            {
                ThrowException(1);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                //    throw; <- nie stracimy stosu wywołań
            }
            catch (InvalidOperationException e) // Nie obsługiwany wyjątek
            {
                // StackTrace - wyrzuca w której linicje jest wyjątek
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally zawsze się wykona");
            }

            try
            {
                ThrowException(1);
            }
            finally
            {
                Console.WriteLine("Nie obsługiwane żadne wyjątki");
            }
        }
    }
}
