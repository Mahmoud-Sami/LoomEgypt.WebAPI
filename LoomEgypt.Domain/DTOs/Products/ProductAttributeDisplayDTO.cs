using LoomEgypt.Domain.Entities;
using System.Collections.Generic;

namespace LoomEgypt.Domain.DTOs.Products
{
    public class ProductAttributeDisplayDTO
    {
        public string Name { get; set; }
        public IEnumerable<ProductAttributeItemDisplayDTO> Items { get; set; }
    }
}
