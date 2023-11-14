using Alza_WebAPI_Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Alza_WebAPI_Database
{
    /// <summary>
    /// 
    /// </summary>
    public class AlzaContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlzaContext"/> class.
        /// </summary>
        public AlzaContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlzaContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public AlzaContext(DbContextOptions<AlzaContext> options) : base(options) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlzaContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        protected AlzaContext(DbContextOptions options) : base(options) { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some pretty nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                }        
                ,new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some pretty nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}