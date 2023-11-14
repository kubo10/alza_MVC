using Alza_WebAPI_Database.Models;

namespace Alza_WebAPI.DTO
{
    /// <summary>
    /// ProductPagination class.
    /// </summary>
    public class ProductPagination
    {
        /// <summary>
        /// List of products.
        /// </summary>
        public List<Product> Products { get; set; } = new List<Product>();
        
        /// <summary>
        /// Page number.
        /// </summary>
        public int PageIndex { get; set; } = 0;
    }
}
