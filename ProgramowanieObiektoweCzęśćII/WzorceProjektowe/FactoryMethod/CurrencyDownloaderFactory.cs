using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.FactoryMethod
{
    class CurrencyDownloaderFactory : ICurrencyDownloaderFactory
    {
        public ICurrencyDownloader CreateCurrencyDownloader(CurrencyWebsite currencyWebsite)
        {
            return currencyWebsite switch
            {
                CurrencyWebsite.NBP => new NbpCurrencyDownloader(),
                CurrencyWebsite.IBAN => new IbanCurrencyDownloader(),
                _ => throw new ArgumentException($"CurrencyDownloader for website {currencyWebsite} was not implemented")
            };
        }
    }
}
