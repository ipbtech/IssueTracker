using System.Linq.Expressions;
using TaskManager.Entities;

namespace TaskManager.DAL.Contracts
{
    public interface IRepository<T> where T : BaseItemId
    {
        public Task CreateAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        public Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        public Task<T?> GetFirstAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
    }
}
