using Alza_WebAPI_Database.Models;

namespace Alza_WebAPI.DTO
{
    public class ProductPagination
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int PageIndex { get; set; } = 0;
    }
}
