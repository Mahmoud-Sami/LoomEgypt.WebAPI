using LoomEgypt.Domain.DTOs.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IServices
{
    public interface IProductServices
    {
        public Task<IEnumerable<ProductDisplayDTO>> GetAllAsync();
        public Task<ProductDisplayDTO> GetProductById(int id);
        //public Task<bool> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO);
    }
}
