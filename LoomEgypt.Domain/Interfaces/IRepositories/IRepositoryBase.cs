using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace LoomEgypt.Domain.Interfaces.IRepositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetByIDAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> Include);

        Task AddAsync(T entity);
        Task AddRagneAsync(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRagne(IEnumerable<T> entities);
    }
}
