using Alza_WebAPI_Database;
using Alza_WebAPI_Database.Models;
using Alza_WebAPI_Domain_Abstraction.Interface;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Linq;

namespace Alza_WebAPI_Domain.Domain
{
    public class ProductDomain : IProductDomain
    {
        /// <summary>
        /// DbContext.
        /// </summary>
        private readonly AlzaContext _dbcontext = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbcontext"></param>
        public ProductDomain(AlzaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // <inheritdoc/>
        public async Task<Product?> GetProductAsync(Guid productId)
        {
            return await _dbcontext.Products.AsNoTracking().FirstOrDefaultAsync(product => product.Id == productId).ConfigureAwait(false);
        }

        // <inheritdoc/>
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _dbcontext.Products.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        // <inheritdoc/>
        public async Task<List<Product>> GetProductsAsync(int productPage, int productPageSize = 10)
        {
            return await _dbcontext.Products.AsNoTracking()
                .OrderBy(product => product.Id)
                .Skip((productPage - 1) * productPageSize)
                .Take(productPageSize)
                .ToListAsync().ConfigureAwait(false);
        }

        // <inheritdoc/>
        public async Task<Product> UpdateProductDescriptionAsync(Guid productId, string description)
        {
            var product = await _dbcontext.Products.FirstAsync(product => product.Id == productId).ConfigureAwait(false);
            product.Description = description;
            await _dbcontext.SaveChangesAsync().ConfigureAwait(false);
            return product;
        }
    }
}
