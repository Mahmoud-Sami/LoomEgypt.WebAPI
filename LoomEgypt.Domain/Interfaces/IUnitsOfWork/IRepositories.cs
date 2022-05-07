using LoomEgypt.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IUnitsOfWork
{
    public interface IRepositories : IDisposable
    {
        public ICategoryRepository CategoryRepository { get; init; }
        public IProductRepository ProductRepository { get; init; }

        Task<int> SaveAsync();
    }
}
