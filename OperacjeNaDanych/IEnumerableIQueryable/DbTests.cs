using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace OperacjeNaDanych.IEnumerableIQueryable
{
    public class DbTests : IAsyncLifetime
    {
        [Fact]
        public async Task should_have_records_after_initialization()
        {
            var exists = await _testDbContext.Actors.AsNoTracking().AnyAsync();

            Assert.True(exists);
        }

        [Fact]
        public void IEnumerable_ShouldFilterAndReturnTwentyNineElements()
        {
            var enumerableFiltered = _testDbContext.Actors.AsNoTracking().AsEnumerable().Where(a => a.Id > 0);
            enumerableFiltered = enumerableFiltered.Where(a => a.Id > 10 && a.Id < 180);
            enumerableFiltered = enumerableFiltered.Where(a => a.Id > 50);
            enumerableFiltered = enumerableFiltered.Where(a => a.Id > 150);
            var listFiltered = enumerableFiltered.ToList();

            Assert.NotEmpty(listFiltered);
            Assert.True(listFiltered.Count == 29);
        }

        [Fact]
        public void IQuerable_ShouldFilterAndReturnTwentyNineElements()
        {
            var queryFiltered = _testDbContext.Actors.AsNoTracking().AsQueryable().Where(a => a.Id > 0);
            queryFiltered = queryFiltered.Where(a => a.Id > 10 && a.Id < 180);
            queryFiltered = queryFiltered.Where(a => a.Id > 50);
            queryFiltered = queryFiltered.Where(a => a.Id > 150);
            var listFiltered = queryFiltered.ToList();

            Assert.NotEmpty(listFiltered);
            Assert.True(listFiltered.Count == 29);
        }

        public async Task DisposeAsync()
        {
            await _testDbContext.Database.EnsureDeletedAsync();
            await _testDbContext.DisposeAsync();
        }

        public async Task InitializeAsync()
        {
            await InitTables();
            var tasks = new List<Task>();
            for (int i = 0; i < 200; i++)
            {
                tasks.Add(_testDbContext.Actors.AddAsync(new Actor() { Id = i + 1 }).AsTask());
            }
            await Task.WhenAll(tasks);
            await _testDbContext.SaveChangesAsync();
        }

        private async Task InitTables()
        {
            var connection = _testDbContext.Database.GetDbConnection();
            await connection.OpenAsync();
            var command = connection.CreateCommand();
            command.CommandText =
                """
                CREATE TABLE Actors(
                Id int PRIMARY KEY,
                Name varchar(300));
                """;
            await command.ExecuteNonQueryAsync();
        }

        private readonly TestDbContext _testDbContext;
        private readonly ITestOutputHelper _output;
        private readonly ILoggerFactory _loggerFactory;

        public DbTests(ITestOutputHelper output)
        {
            _loggerFactory = new LoggerFactory(new List<ILoggerProvider> { new TestLoggerProvider(output) });
            _testDbContext = new TestDbContext(_loggerFactory);
            _output = output;
        }

        class TestLoggerProvider : ILoggerProvider
        {
            ITestOutputHelper _output;

            public TestLoggerProvider(ITestOutputHelper output)
                => _output = output;

            public ILogger CreateLogger(string categoryName)
                => new TestLogger(categoryName, _output);

            public void Dispose()
            {
            }
        }

        class TestLogger : ILogger
        {
            string _categoryName;
            ITestOutputHelper _output;

            public TestLogger(string categoryName, ITestOutputHelper output)
            {
                _categoryName = categoryName;
                _output = output;
            }

            public bool IsEnabled(LogLevel logLevel)
                => _categoryName == DbLoggerCategory.Database.Command.Name;

            public void Log<TState>(
                LogLevel logLevel,
                EventId eventId,
                TState state,
                Exception exception,
                Func<TState, Exception, string> formatter)
            {
                _output.WriteLine(formatter(state, exception));
            }

            public IDisposable BeginScope<TState>(TState state)
                => null;
        }
    }
}
