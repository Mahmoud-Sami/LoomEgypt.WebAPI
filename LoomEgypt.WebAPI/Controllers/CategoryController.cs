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
        public async Task<ActionResult<IEnumerable<CategoryDisplayDTO>>> GetAllGategories()
        {
            try
            {
                var result = await _services.Categories.GetAllAsync();
                return Ok(result);  
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoryProductDisplayDTO>> GetGategoryByID(int id)
        {
            try
            {
                var result = await _services.Categories.GetByIdAsync(id);
                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
