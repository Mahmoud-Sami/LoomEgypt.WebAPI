using LoomEgypt.Domain.Entities.Categories;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IRepositories
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        public Task<Category> GetCategoryByIdAsync(int id);
    }
}
