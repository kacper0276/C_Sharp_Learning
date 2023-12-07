using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.FactoryMethod
{
    class NbpCurrencyDownloader : ICurrencyDownloader
    {
        public void Download(Currency currency)
        {
            Console.WriteLine($"{DateTime.UtcNow} NBP Currency downloaded {currency.Code} Rate: {new Random().Next(1, 5)}");
        }
    }
}
