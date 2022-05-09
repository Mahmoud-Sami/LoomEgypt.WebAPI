using LoomEgypt.Domain.Entities.Products;
using LoomEgypt.Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LoomEgypt.DataAccess.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<Product> GetProductByIDAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            await _context.Entry(product).Collection(x => x.Attributes).LoadAsync();
            await _context.Entry(product).Collection(x => x.Gallery).LoadAsync();
            await _context.Entry(product).Reference(x => x.ProductInventory).LoadAsync();
            await _context.Entry(product).Reference(x => x.Category).LoadAsync();
            return product; ;
        }
    }
}
