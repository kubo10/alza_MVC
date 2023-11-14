using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alza_WebAPI_Database.Models
{
    /// <summary>
    /// Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product Id.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Product image Uri.
        /// </summary>
        [Required]
        [MaxLength(400)]
        public string ImgUri { get; set; } = default!;

        /// <summary>
        /// Product price.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } 

        /// <summary>
        /// Product description.
        /// </summary>
        [MaxLength(4000)]
        public string Description { get; set; } = default!;    
    }
}
