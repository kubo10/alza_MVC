using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase.DatabaseSeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alza_WebAPI_InMemoryDatabase
{
    public class InMemoryDatabaseSeed
    {
        protected AlzaContext DbContext { get; set; }
        protected ProductSeed ProductSeed { get; set; } = default!;
        public InMemoryDatabaseSeed(AlzaContext _dbContext)
        {
            DbContext = _dbContext;
            ProductSeed = new ProductSeed(DbContext);
        }

        public async Task SeedDatabase()
        {
            await ProductSeed.SeedDatabase().ConfigureAwait(false);
        }
    }
}
