using Alza_WebAPI_Database.Models;

namespace Alza_WebAPI_Domain_Abstraction.Interface
{
    /// <summary>
    /// ProductDomain interface.
    /// </summary>
    public interface IProductDomain
    {
        /// <summary>
        /// Get product by Id.
        /// </summary>
        /// <param name="productId">Product Id.</param>
        /// <returns>Return product by Id if exist, else return null.</returns>
        Task<Product?> GetProductAsync(Guid productId);

        /// <summary>
        /// Get all products.
        /// </summary>
        /// <returns>Returns all products.</returns>
        Task<List<Product>> GetProductsAsync();

        /// <summary>
        /// Get product with pagination.
        /// </summary>
        /// <param name="productPage">Page number.</param>
        /// <param name="productPageSize">Size of product page. Default value is 10 product per page.</param>
        /// <returns>Return products by pages.</returns>
        Task<List<Product>> GetProductsAsync(int productPage, int productPageSize = 10);

        /// <summary>
        /// Update product description.
        /// </summary>
        /// <param name="productId">Product Id.</param>
        /// <param name="description">Description.</param>
        /// <returns>Return product with updated description.</returns>
        Task<Product> UpdateProductDescriptionAsync(Guid productId, string description);
    }
}
