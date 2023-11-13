using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase.DatabaseSeed;

namespace Alza_WebAPI_InMemoryDatabase
{
    /// <summary>
    /// InMemoryDatabaseSeed.
    /// </summary>
    public class InMemoryDatabaseSeed
    {
        /// <summary>
        /// DbContext.
        /// </summary>
        protected AlzaContext DbContext { get; set; }

        /// <summary>
        /// ProductSeed.
        /// </summary>
        protected ProductSeed ProductSeed { get; set; } = default!;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryDatabaseSeed"/> class.
        /// </summary>
        /// <param name="_dbContext"></param>
        public InMemoryDatabaseSeed(AlzaContext _dbContext)
        {
            DbContext = _dbContext;
            ProductSeed = new ProductSeed(DbContext);
        }

        /// <summary>
        /// Seeding database
        /// </summary>
        /// <returns>Seeded database</returns>
        public async Task SeedDatabase()
        {
            await ProductSeed.SeedDatabase().ConfigureAwait(false);
        }
    }
}
