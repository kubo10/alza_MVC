using Alza_WebAPI_Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.SymbolStore;

namespace Alza_WebAPI_Database
{
    public class AlzaContext : DbContext
    {
        public AlzaContext()
        {
        }
        public AlzaContext(DbContextOptions<AlzaContext> options) : base(options) { }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Some pretty nice flowers",
        //            ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
        //            Price = 10002.22M,
        //            Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
        //                            Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
        //                            consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
        //                            quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
        //        }
        //    );
        //}

        public DbSet<Product> Products { get; set; }
    }
}