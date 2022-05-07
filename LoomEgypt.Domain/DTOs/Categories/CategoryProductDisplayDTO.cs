/// <summary>
/// Used to show data for a specific category
/// including the products for this category.
/// </summary>

using LoomEgypt.Domain.DTOs.Products;
using System.Collections.Generic;

namespace LoomEgypt.Domain.DTOs.Category
{
    public class CategoryProductDisplayDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ShippingFees { get; set; }
        public IEnumerable<ProductDisplayDTO> Products { get; set; }
    }
}
