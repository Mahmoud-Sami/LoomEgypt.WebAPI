using LoomEgypt.Domain.DTOs.Products;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServices _services;
        public ProductController(IServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDisplayDTO>>> GetAllProducts()
        {
            try
            {
                var result = await _services.Products.GetAllAsync();
                return Ok(result);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDisplayDTO>> GetProductById(int id)
        {
            try
            {
                var result = await _services.Products.GetProductById(id);
                return Ok(result);
            }
            catch (System.Exception)
        {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
