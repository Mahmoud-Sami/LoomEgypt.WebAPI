using LoomEgypt.Domain.DTOs.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IServices
{
    public interface ICategoryServices
    {
        public Task<IEnumerable<CategoryDisplayDTO>> GetAllAsync();
        public Task<bool> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO);
        public Task<CategoryProductDisplayDTO> GetByIdAsync(int id);
    }
}
