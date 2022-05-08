using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoomEgypt.Domain.Entities
{
    [Table("ProductImages")]
    public class ProductImage : BaseEntity<int>
    {
        [Required]
        public string ImagePath { get; set; }

        public string ImageDescription { get; set; }

        //Navigation Property
        public int productID { get; set; }
    }
}
