using LoomEgypt.Domain.Entities;
using System.Collections.Generic;

namespace LoomEgypt.Domain.DTOs.Products
{
    public class ProductDisplayDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int AvailableQuantity { get; set; }

        // Computed field based on "AvailableQuantity"
        public bool inStock { get; set; }

        public IEnumerable<ProductAttributeDisplayDTO> Attributes { get; set; }
        public IEnumerable<ProductImageDisplayDTO> Gallery { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
