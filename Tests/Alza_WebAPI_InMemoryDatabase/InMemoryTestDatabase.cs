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
        protected InMemoryTestAlzaContext DbContext { get; private set; } = default!;

        /// <summary>
        /// DbGuid.
        /// </summary>
        protected Guid DbGuid { get; } = Guid.NewGuid();

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryTestDatabase"/> class.
        /// </summary>
        public InMemoryTestDatabase()
        {
            Init();
        }

        /// <summary>
        /// Initialization of in memory database
        /// </summary>
        private void Init()
        {
            var options = new DbContextOptionsBuilder<InMemoryTestAlzaContext>().UseInMemoryDatabase(databaseName: DbGuid.ToString()).Options;

            DbContext = new InMemoryTestAlzaContext(options);
            DbContext.Database.EnsureCreated();
        }
    }
}