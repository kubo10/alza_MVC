using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase.DatabaseSeed;
using Microsoft.EntityFrameworkCore;

namespace Alza_WebAPI_InMemoryDatabase
{
    public class InMemoryTestDatabase
    {
        protected AlzaContext DbContext { get; private set; } = default!;
        protected Guid DbGuid { get; } = Guid.NewGuid();
        private InMemoryDatabaseSeed InMemoryDatabaseSeed { get; set; } = default!;

        public InMemoryTestDatabase()
        {
            Init();
            InMemoryDatabaseSeed = new InMemoryDatabaseSeed(DbContext);
            //ProductSeed = new ProductSeed(DbContext);
        }

        public InMemoryTestDatabase(AlzaContext dbContext)
        {
            DbContext = dbContext;
            InMemoryDatabaseSeed = new InMemoryDatabaseSeed(DbContext);
            //ProductSeed = new ProductSeed(DbContext);
        }

        private void Init()
        {
            var options = new DbContextOptionsBuilder<AlzaContext>().UseInMemoryDatabase(databaseName: DbGuid.ToString()).Options;

            DbContext = new AlzaContext(options);
            DbContext.Database.EnsureCreated();
        }

        public async Task SeedDatabase()
        {
            await InMemoryDatabaseSeed.SeedDatabase();
            //await ProductSeed.SeedDatabase().ConfigureAwait(false);
        }
    }
}