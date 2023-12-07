using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.FactoryMethod
{
    class CurrencyDownloaderManage
    {
        public void DownloadCurrency(CurrencyWebsite currencyWebsite, Currency currency)
        {
            ICurrencyDownloaderFactory currencyDownloaderFactory = new CurrencyDownloaderFactory();
            var downloader = currencyDownloaderFactory.CreateCurrencyDownloader(currencyWebsite);
            downloader.Download(currency);
        }
    }
}
