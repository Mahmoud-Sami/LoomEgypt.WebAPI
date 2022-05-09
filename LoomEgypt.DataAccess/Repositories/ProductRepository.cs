using LoomEgypt.Domain.Entities;
using LoomEgypt.Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomEgypt.DataAccess.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            await _context.Entry(product).Collection(x => x.Attributes).LoadAsync();
            await _context.Entry(product).Collection(x => x.Gallery).LoadAsync();
            await _context.Entry(product).Reference(x => x.ProductInventory).LoadAsync();
            await _context.Entry(product).Reference(x => x.Category).LoadAsync();

            foreach (var attribute in product.Attributes)
            {
                await _context.Entry(attribute).Collection(x => x.Items).LoadAsync();
            }
            return product; ;
        }
    }
}
