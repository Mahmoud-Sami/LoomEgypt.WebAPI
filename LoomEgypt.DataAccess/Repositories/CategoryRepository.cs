using LoomEgypt.Domain.Entities.Categories;
using LoomEgypt.Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
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

        public override async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _context.Categories
                .Include(category => category.Products)
                .ThenInclude(product => product.Attributes)
                .Include(category => category.Products)
                .ThenInclude(product => product.Gallery)
                .Include(category => category.Products)
                .ThenInclude(product => product.ProductInventory)
                .ToListAsync();

            return categories;
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
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
