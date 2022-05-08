using LoomEgypt.Domain.Entities;
using System.Threading.Tasks;

namespace LoomEgypt.Domain.Interfaces.IRepositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        public Task<Product> GetProductByIDAsync(int id);
    }
}
