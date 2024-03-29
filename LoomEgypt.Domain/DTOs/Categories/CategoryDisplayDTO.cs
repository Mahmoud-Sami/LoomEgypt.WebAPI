﻿/// <summary>
/// Show all categories details.
/// </summary>
namespace LoomEgypt.Domain.DTOs.Category
{
    public class CategoryDisplayDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ShippingFees { get; set; }
    }
}
