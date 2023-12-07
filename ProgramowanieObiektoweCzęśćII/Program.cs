// Wzorce projektowe: https://refactoring.guru/pl/design-patterns/catalog

// FactoryMethod
using ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Decorator;
using ProgramowanieObiektoweCzęśćII.WzorceProjektowe.FactoryMethod;
using ProgramowanieObiektoweCzęśćII.WzorceProjektowe.Strategy;

var manager = new CurrencyDownloaderManage();
var currency = new Currency { Code = "EUR", Created = DateTime.UtcNow };
manager.DownloadCurrency(CurrencyWebsite.NBP, currency);
manager.DownloadCurrency(CurrencyWebsite.IBAN, currency);

// Decorator
var message = new TheMessage
{
    Header = new Dictionary<string, string> { { "Client", "Destop" }, { "Authorize", "Token" } },
    Body = "This is body"
};
var sender = new Sender();
var decoratedSender = new SenderDecorator(sender);
decoratedSender.Send(message);

// ------------------------------------------------
// Strategy
var product = new Product() { Name = "Test#1" };
var inMemoryRepository = new InMemoryDatabase<Product>();
var mongoClient = new MongoClient();
var mongoRepository = new MongoRepository<Product>(mongoClient);
var repositoryManager = new RepositoryManager<Product>(new IRepository<Product>[] { inMemoryRepository, mongoRepository });
var repo = repositoryManager.GetRepository(Database.Mongo);
repo.Add(product);
repo = repositoryManager.GetRepository(Database.InMemory);
repo.Add(product);