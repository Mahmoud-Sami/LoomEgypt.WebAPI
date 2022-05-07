using LoomEgypt.Domain.Entities;
using System.Collections.Generic;
namespace LoomEgypt.Domain.DTOs.Products
{
    public class ProductDisplayDTO
    {
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Images { get; set; }

    }
}
