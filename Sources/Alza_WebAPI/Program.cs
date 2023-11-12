using Alza_WebAPI.Domain;
using Alza_WebAPI.Domain.Interface;
using Alza_WebAPI.FilterExtension;
using Alza_WebAPI_Database;
using Alza_WebAPI_InMemoryDatabase;
using Asp.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

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

            builder.Services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1.0);
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
            }).AddApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.OperationFilter<ApiDefaultValues>();
            });
            builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureApiDocumentationOptions>();
            builder.Services.AddDatabaseContext();

            builder.Services.AddScoped<IProductDomain, ProductDomain>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.DocumentTitle = "Alza WebAPI";
                    options.SwaggerEndpoint($"/swagger/v1/swagger.json", $"v1");
                    options.SwaggerEndpoint($"/swagger/v2/swagger.json", $"v2");
                });
            }

            app.UseHttpsRedirection();

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
                serviceCollection.AddDbContext<AlzaContext>(options => options.UseInMemoryDatabase(databaseName: "InMemoryDbContext"));
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
