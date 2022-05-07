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

        public async Task<IEnumerable<ProductDisplayDTO>> GetAll()
        {
            var products = (await _repositories.ProductRepository.GetAllAsync(p => p.Images)).ToList();
            var categories = (await _repositories.CategoryRepository.GetAllAsync()).ToList();
            var result = products.Join(categories,
                                       product => product.CategoryID,
                                       category => category.Id,
                                       (product, category) => new ProductDisplayDTO()
                                       {
                                           Name = product.Name,
                                           Brand = product.Brand,
                                           CategoryName = category.Name,
                                           Description = product.Description,
                                           Images = from image in product.Images select image.Path
                                       });
            return result;
        }
    }
}
