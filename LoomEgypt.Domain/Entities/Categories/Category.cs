using LoomEgypt.Domain.Entities.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities.Categories
{
    [Table("Categories")]
    public class Category : BaseEntity<int>
    {
        [Required, MinLength(2), MaxLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ShippingFees { get; set; }

        //Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}
