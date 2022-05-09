using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("ProductAttributeItems")]
    public class ProductAttributeItem : BaseEntity<int>
    {
        public string Value { get; set; }
        public string DisplayValue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ExtraFees { get; set; }

        public int ProductAttributeId { get; set; }
    }
}
