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
        public async Task<IEnumerable<ProductDisplayDTO>> getAll()
        {
            return await _services.Products.GetAll();
        }
    }
}
