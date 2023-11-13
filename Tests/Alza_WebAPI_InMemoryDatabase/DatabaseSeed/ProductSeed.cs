using Alza_WebAPI_Database;
using Alza_WebAPI_Database.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alza_WebAPI_InMemoryDatabase.DatabaseSeed
{
    public class ProductSeed
    {
        private readonly AlzaContext DbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSeed"/> class.
        /// </summary>
        /// <param name="dbcontext">Dbcontext</param>
        public ProductSeed(AlzaContext dbcontext)
        {
            DbContext = dbcontext;
        }

        /// <summary>
        /// Seeding product.
        /// </summary>
        /// <returns>Seeded database.</returns>
        public async Task SeedDatabase()
        {
            DbContext.AddRange(new[]
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Some nice flowers",
                    ImgUri = "https://cdn.firstcry.com/education/2022/12/12101916/Flower-Names-In-English-For-Kids.jpg",
                    Price = 10002.22M,
                    Description = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Pellentesque ipsum.
                                    Etiam posuere lacus quis dolor. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet,
                                    consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam 
                                    quaerat voluptatem. Vestibulum erat nulla, ullamcorper nec, rutrum non, nonummy ac, erat. Nullam eget nisl. Cras elementum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor"
                },
            });

            await DbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
