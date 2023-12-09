using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;


namespace OperacjeNaDanych.IEnumerableIQueryable
{
    internal class TestDbContext : DbContext
    {
        private readonly ILoggerFactory? _loggerFactory;

        public DbSet<Actor> Actors { get; set; }

        public TestDbContext()
        {
        }

        public TestDbContext(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=:memory:");
            if (_loggerFactory is not null)
            {
                optionsBuilder.UseLoggerFactory(_loggerFactory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
