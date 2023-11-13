using Alza_WebAPI.DTO;
using Alza_WebAPI_Database.Models;
using Alza_WebAPI_Domain_Abstraction.Interface;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Alza_WebAPI.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductDomain _productDomain;

        private readonly ILogger<ProductController> _logger;


        public ProductController(IProductDomain productDomain, ILogger<ProductController> logger)
        {
            _productDomain = productDomain;
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("products")]
        [MapToApiVersion("1")]
        [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                return Ok(await _productDomain.GetProductsAsync());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get products end with error");
                return BadRequest();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet("products/{page}")]
        [MapToApiVersion("2")]
        [ProducesResponseType(typeof(IEnumerable<ProductPagination>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductsWithPagination([Required][Range(1, int.MaxValue)] int page)
        {
            try
            {
                var products = await _productDomain.GetProductsAsync(page);
                return Ok(new ProductPagination { Products = products, PageIndex = page });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get products with pagination end with error");
                return BadRequest();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1"), MapToApiVersion("2")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProduct([Required] Guid productId)
        {
            try
            {
                var product = await _productDomain.GetProductAsync(productId);
                if (product == null)
                {
                    return NotFound("Product was not found");
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetProduct error");
                return BadRequest();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        [HttpPut]
        [MapToApiVersion("1"), MapToApiVersion("2")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateProductDescription([Required] Guid productId, [MaxLength(4000)] string description)
        {
            try
            {
                var product = await _productDomain.GetProductAsync(productId);
                if (product == null)
                {
                    return NotFound("Product was not found");
                }
                product = await _productDomain.UpdateProductDescriptionAsync(productId, description).ConfigureAwait(false);
                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateProductDescription error.");
                return BadRequest();
            }
        }
    }
}