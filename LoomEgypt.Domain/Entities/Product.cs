using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("Products")]
    public class Product : BaseEntity<int>
    {
        [Required, MinLength(2)]
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        #region Navigation Properties

        public ICollection<ProductAttribute> Attributes { get; set; }

        public ICollection<ProductImage> Gallery { get; set; }

        public ProductInventory ProductInventory { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        #endregion

    }
}
