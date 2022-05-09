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
        public async Task<ActionResult<IEnumerable<dynamic>>> GetAllGategories(int? count, bool? shuffle)
        {
            try
            {
                var result = await _services.Categories.GetAllAsync(count, shuffle);
                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoryProductDisplayDTO>> GetCategoryById(int id, int? count, bool? shuffle)
        {
            try
            {
                var result = await _services.Categories.GetByIdAsync(id, count, shuffle);
                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult<CategoryProductDisplayDTO>> AddCategory(CategoryCreateDTO categoryDTO)
        {
            try
            {
                var category = await _services.Categories.AddCategoryAsync(categoryDTO);
                return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

