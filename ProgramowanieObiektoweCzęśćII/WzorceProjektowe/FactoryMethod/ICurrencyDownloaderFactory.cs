namespace ProgramowanieObiektoweCzęśćII.WzorceProjektowe.FactoryMethod
{
    interface ICurrencyDownloaderFactory
    {
        ICurrencyDownloader CreateCurrencyDownloader(CurrencyWebsite currencyWebsite);
    }
}
