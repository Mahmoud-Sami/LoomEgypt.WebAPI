using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("ProductsInventory")]
    public class ProductInventory : BaseEntity<int>
    {
        public int Quantity { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
