using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("Category")]
    public class Category : BaseEntity<int>
    {
        [Required, MinLength(2), MaxLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal ShippingFees { get; set; }

        //Navigation Property
        public IEnumerable<Product> Products { get; set; }
    }
}
