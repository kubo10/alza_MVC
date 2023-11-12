using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase;
using Microsoft.EntityFrameworkCore;

namespace Alza_WebAPI
{
    internal static class Program
    {
        internal static IConfiguration Configuration { get; private set; } = default!;

        private static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            Configuration = builder.Configuration;
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDatabaseContext();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            await app.SeedDatabaseContext();

            app.Run();

        }
        /// <summary>
        /// Set DbContext in Application.
        /// </summary>
        /// <param name="serviceCollection">IServiceCollection.</param>
        /// <returns>ServiceCollection with added DBContext</returns>
        private static IServiceCollection AddDatabaseContext(this IServiceCollection serviceCollection)
        {
            var useInMemoryDatabase = Configuration.GetValue<bool>("UseInMemoryDatabase");
            if (!useInMemoryDatabase)
            {
                serviceCollection.AddDbContext<AlzaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase")));
            }
            else
            {
                serviceCollection.AddDbContext<AlzaContext>(options => options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()));
            }
            return serviceCollection;
        }

        /// <summary>
        /// Seeding InMemoryDatabase with data.
        /// </summary>
        /// <param name="webApplication">WebApplication.</param>
        /// <returns>Seeded InMemoryDatabase</returns>
        /// <exception cref="ArgumentNullException">DbContext was not created</exception>
        private static async Task<WebApplication> SeedDatabaseContext(this WebApplication webApplication)
        {
            using var scope = webApplication.Services.CreateScope();
            var context = scope.ServiceProvider.GetService<AlzaContext>() ?? throw new ArgumentNullException("DbContext was not created");
            context.Database.EnsureCreated();
            if (context.Database.IsInMemory())
            {
                var databaseSeed = new InMemoryDatabaseSeed(context);
                await databaseSeed.SeedDatabase().ConfigureAwait(false);
            }

            return webApplication;
        }
    }
}
