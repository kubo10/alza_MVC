using Alza_WebAPI_Database;
using Alza_WebAPI_Database.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alza_WebAPI_InMemoryDatabase
{
    /// <summary>
    /// AlzaContextInMemory.
    /// </summary>
    public class InMemoryTestAlzaContext : AlzaContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryTestAlzaContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public InMemoryTestAlzaContext(DbContextOptions<InMemoryTestAlzaContext> options) : base(options) { }

        /// <summary>
        /// Seeding InMemoryTestAlzaContext dbContext with data for unit tests.
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Some pretty nice rainbow flowers",
                            ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                            Price = 10002.22M,
                            Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                                        Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                                        consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                                        quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
                        },
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
            );
        }

        /// <summary>
        /// Overrides function SaveChanges and enables possibility to catch data anotation validation.
        /// </summary>
        /// <returns>Overrided function SaveChanges</returns>
        public override int SaveChanges()
        {
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(
                    entity,
                    validationContext,
                    validateAllProperties: true);
            }

            return base.SaveChanges();
        }

        /// <summary>
        /// Overrides function SaveChangesAsync and enables possibility to catch data anotation validation.
        /// </summary>
        /// <param name="cancellationToken">CancellationToken.</param>
        /// <returns>Overrided function SaveChangesAsync </returns>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(
                    entity,
                    validationContext,
                    validateAllProperties: true);
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
