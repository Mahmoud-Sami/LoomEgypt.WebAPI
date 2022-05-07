using AutoMapper;
using LoomEgypt.Domain.DTOs.Products;
using LoomEgypt.Domain.Interfaces.IServices;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using LoomEgypt.Domain.Entities;

namespace LoomEgypt.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IRepositories _repositories;
        private readonly IMapper _mapper;

        public ProductServices(IRepositories repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDisplayDTO>> GetAllAsync()
        {
            var products = await _repositories.ProductRepository
                .GetAllAsync(x => x.Category, x => x.Gallery, x => x.Attributes, x => x.ProductInventory);

            var result = _mapper.Map<IEnumerable<ProductDisplayDTO>>(products);
            return result;
        }

        public async Task<ProductDisplayDTO> GetProductById(int id)
        {
            var product = await _repositories.ProductRepository.GetProductByIDAsync(id);
            var productDisplay = _mapper.Map<ProductDisplayDTO>(product);
            return productDisplay;
        }
    }
}
