using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("ProductImage")]
    public class ProductImage : BaseEntity<int>
    {
        [Required]
        public string Path { get; set; }

        //Navigation Property
        public int productID { get; set; }
    }
}
