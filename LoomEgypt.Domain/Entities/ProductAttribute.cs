using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("ProductAttributes")]
    public class ProductAttribute : BaseEntity<int>
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public int ProductID { get; set; }
    }
}
