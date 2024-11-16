using System.Linq.Expressions;
using TaskManager.Entities.Base;

namespace TaskManager.DAL.Contracts.Repositories
{
    public interface IRepository<T> where T : BaseItemDated
    {
        public Task<T> CreateAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        public Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        public Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);
    }
}
