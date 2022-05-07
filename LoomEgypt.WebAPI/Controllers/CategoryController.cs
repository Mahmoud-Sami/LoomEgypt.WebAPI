using LoomEgypt.Domain.DTOs.Category;
using LoomEgypt.Domain.Entities;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServices _services;
        public CategoryController(IServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDisplayDTO>> GetAllGategories()
        {
            IEnumerable<CategoryDisplayDTO> x = await _services.Categories.GetAll();
            return x;
        }
    }
}
