using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("ProductAttributes")]
    public class ProductAttribute : BaseEntity<int>
    {
        [Required]
        public string Name { get; set; }
        public ICollection<ProductAttributeItem> Items { get; set; }

        public int ProductId { get; set; }
    }
}
