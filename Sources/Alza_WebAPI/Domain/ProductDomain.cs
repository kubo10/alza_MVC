using Alza_WebAPI.Domain.Interface;
using Alza_WebAPI_Database;
using Alza_WebAPI_Database.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Linq;

namespace Alza_WebAPI.Domain
{
    public class ProductDomain : IProductDomain
    {
        private readonly AlzaContext _dbcontext = default!;

        public ProductDomain(AlzaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Product?> GetProductAsync(Guid productId)
        {
            return await _dbcontext.Products.AsNoTracking().FirstOrDefaultAsync(product => product.Id == productId).ConfigureAwait(false);
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _dbcontext.Products.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<Product>> GetProductsAsync(int productPage, int productPageSize = 10)
        {
            return await _dbcontext.Products.AsNoTracking()
                .OrderBy(product => product.Id)
                .Skip((productPage - 1) * productPageSize)
                .Take(productPageSize)
                .ToListAsync().ConfigureAwait(false);
        }

        public async Task<Product> UpdateProductDescriptionAsync(Guid productId, string description)
        {
            var product = await _dbcontext.Products.FirstAsync(product => product.Id == productId).ConfigureAwait(false);
            product.Description = description;
            await _dbcontext.SaveChangesAsync().ConfigureAwait(false);
            return product;
        }
    }
}
