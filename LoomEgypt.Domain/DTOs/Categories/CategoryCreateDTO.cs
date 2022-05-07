using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
