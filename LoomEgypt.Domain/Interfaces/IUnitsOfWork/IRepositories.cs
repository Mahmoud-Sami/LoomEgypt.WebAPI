using System;
using System.Threading.Tasks;

using LoomEgypt.Domain.Interfaces.IRepositories;

namespace LoomEgypt.Domain.Interfaces.IUnitsOfWork
{
    public interface IRepositories : IDisposable
    {
        public ICategoryRepository CategoryRepository { get; init; }
        public IProductRepository ProductRepository { get; init; }

        Task<int> SaveAsync();
    }
}
