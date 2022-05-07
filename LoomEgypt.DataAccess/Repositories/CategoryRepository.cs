using LoomEgypt.Domain.Entities;
using LoomEgypt.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomEgypt.DataAccess.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<Category> GetCategoryByIDAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            await _context.Entry(category).Collection(x => x.Products).LoadAsync();
            foreach (var item in category.Products)
            {
                await _context.Entry(item).Collection(x => x.Attributes).LoadAsync();
                await _context.Entry(item).Collection(x => x.Gallery).LoadAsync();
                await _context.Entry(item).Reference(x => x.ProductInventory).LoadAsync();
            }
            return category;
        }
    }
}
