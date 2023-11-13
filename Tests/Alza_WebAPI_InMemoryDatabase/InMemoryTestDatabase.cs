using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase.DatabaseSeed;
using Microsoft.EntityFrameworkCore;

namespace Alza_WebAPI_InMemoryDatabase
{
    /// <summary>
    /// InMemoryTestDatabase.
    /// </summary>
    public class InMemoryTestDatabase
    {
        /// <summary>
        /// InMemoryAlzaContext.
        /// </summary>
        protected InMemoryAlzaContext DbContext { get; private set; } = default!;

        /// <summary>
        /// DbGuid.
        /// </summary>
        protected Guid DbGuid { get; } = Guid.NewGuid();

        /// <summary>
        /// InMemoryDatabaseSeed.
        /// </summary>
        private InMemoryDatabaseSeed InMemoryDatabaseSeed { get; set; } = default!;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryTestDatabase"/> class.
        /// </summary>
        public InMemoryTestDatabase()
        {
            Init();
            InMemoryDatabaseSeed = new InMemoryDatabaseSeed(DbContext);
        }

        /// <summary>
        /// Initialization of in memory database
        /// </summary>
        private void Init()
        {
            var options = new DbContextOptionsBuilder<InMemoryAlzaContext>().UseInMemoryDatabase(databaseName: DbGuid.ToString()).Options;

            DbContext = new InMemoryAlzaContext(options);
            DbContext.Database.EnsureCreated();
        }
        /// <summary>
        /// Seed Database
        /// </summary>
        /// <returns>Return seeded DB</returns>
        public async Task SeedDatabase()
        {
            await InMemoryDatabaseSeed.SeedDatabase();
        }
    }
}