using Alza_WebAPI_Database;
using Alza_WebAPI_Database.Models;
using Alza_WebAPI_Domain_Abstraction.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alza_WebAPI_Domain.Domain
{
    /// <summary>
    /// ProductDomain class.
    /// </summary>
    public class ProductDomain : IProductDomain
    {
        /// <summary>
        /// DbContext.
        /// </summary>
        private readonly AlzaContext _dbcontext = default!;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDomain"/> class.
        /// </summary>
        /// <param name="dbcontext">DbContext.</param>
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
