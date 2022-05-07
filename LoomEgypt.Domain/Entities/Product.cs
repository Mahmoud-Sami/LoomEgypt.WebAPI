using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("Product")]
    public class Product : BaseEntity<int>
    {
        [Required, MinLength(2)]
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public IEnumerable<ProductImage> Images { get; set; }

        public int CategoryID { get; set; }
    }
}
