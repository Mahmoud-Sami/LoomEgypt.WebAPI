using LoomEgypt.DataAccess.Repositories;
using LoomEgypt.Domain.Interfaces.IRepositories;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomEgypt.DataAccess.UnitsOfWork
{
    public class Repositories : IRepositories
    {
        private readonly ApplicationContext _context;
        public ICategoryRepository CategoryRepository { get; init; }
        public IProductRepository ProductRepository { get; init; }

        public Repositories(ApplicationContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(context);
            ProductRepository = new ProductRepository(context);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();  
        }

        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}
