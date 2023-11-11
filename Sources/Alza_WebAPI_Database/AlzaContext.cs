using Alza_WebAPI_Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Alza_WebAPI_Database
{
    public class AlzaContext : DbContext
    {
        private readonly IConfiguration Configuration = default!;

        public AlzaContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Product> Products { get; set; }
    }
}