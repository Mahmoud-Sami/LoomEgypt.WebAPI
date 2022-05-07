using LoomEgypt.Domain.Interfaces.IServices;

namespace LoomEgypt.Domain.Interfaces.IUnitsOfWork
{
    public interface IServices
    {
        public ICategoryServices Categories { get; init; }
        public IProductServices Products { get; init; }

    }
}
