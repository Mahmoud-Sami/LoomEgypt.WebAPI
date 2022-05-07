using LoomEgypt.Domain.DTOs.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IServices
{
    public interface ICategoryServices
    {
        public Task<IEnumerable<CategoryDisplayDTO>> GetAll();
        public Task<bool> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO);
    }
}
