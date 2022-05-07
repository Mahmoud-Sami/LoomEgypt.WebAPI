using LoomEgypt.Domain.DTOs.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IServices
{
    public interface IProductServices
    {
        public Task<IEnumerable<ProductDisplayDTO>> GetAll();
        //public Task<bool> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO);
    }
}
