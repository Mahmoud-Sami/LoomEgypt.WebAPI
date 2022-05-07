/// <summary>
/// 
/// </summary>
using System.ComponentModel.DataAnnotations;

namespace LoomEgypt.Domain.DTOs.Category
{
    public class CategoryCreateDTO
    {
        [Required, MinLength(2), MaxLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal ShippingFees { get; set; }
    }
}
