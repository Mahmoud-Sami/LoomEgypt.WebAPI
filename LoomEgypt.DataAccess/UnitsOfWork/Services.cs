using AutoMapper;
using LoomEgypt.Domain.Interfaces.IServices;
using LoomEgypt.Domain.Interfaces.IUnitsOfWork;
using LoomEgypt.Services;

namespace LoomEgypt.DataAccess.UnitsOfWork
{
    public class AppServices : IServices
    {
        public ICategoryServices Categories { get; init; }
        public IProductServices Products { get; init; }

        public AppServices(IRepositories repositories, IMapper mapper)
        {
            Categories = new CategoryServices(repositories, mapper);
            Products = new ProductServices(repositories, mapper);
        }
    }
}
