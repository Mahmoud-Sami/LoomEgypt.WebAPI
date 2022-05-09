using LoomEgypt.Domain.DTOs.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IServices
{
    public interface ICategoryServices
    {
        public Task<IEnumerable<CategoryDisplayDTO>> GetAllAsync();
        public Task<CategoryProductDisplayDTO> GetByIdAsync(int id, int? count, bool? shuffle);
        public Task<CategoryProductDisplayDTO> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO);
    }
}
