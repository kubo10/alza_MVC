using Alza_WebAPI_Database.Models;

namespace Alza_WebAPI_Domain_Abstraction.Interface
{
    public interface IProductDomain
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<Product?> GetProductAsync(Guid productId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetProductsAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productPage"></param>
        /// <param name="productPageSize"></param>
        /// <returns></returns>
        Task<List<Product>> GetProductsAsync(int productPage, int productPageSize = 10);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<Product> UpdateProductDescriptionAsync(Guid productId, string description);
    }
}
