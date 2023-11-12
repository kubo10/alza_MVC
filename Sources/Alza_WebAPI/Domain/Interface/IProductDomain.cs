using Alza_WebAPI_Database.Models;

namespace Alza_WebAPI.Domain.Interface
{
    public interface IProductDomain
    {
        Task<Product?> GetProductAsync(Guid productId);
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> GetProductsAsync(int productPage, int productPageSize = 10);
        Task<Product> UpdateProductDescriptionAsync(Guid productId, string description);
    }
}
