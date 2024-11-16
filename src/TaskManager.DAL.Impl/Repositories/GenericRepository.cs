using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaskManager.DAL.Contracts;
using TaskManager.Entities;

namespace TaskManager.DAL.Impl.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseItemId
    {
        protected readonly TaskManagerDbContext dbContext;
        protected DbSet<T> dbSet;

        public GenericRepository(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            entity.CreatedDateTimeUTC = DateTime.UtcNow;
            entity.UpdatedDateTimeUTC = DateTime.UtcNow;
            await dbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.UpdatedDateTimeUTC = DateTime.UtcNow;
            dbContext.Update(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            dbSet.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            return await Include(includeProperties).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Include(includeProperties);
            return await query.Where(predicate).AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            return await dbSet.FindAsync(id);
        }

        private IQueryable<T> Include(params Expression<Func<T, object>>[] includeProperties)
        {
            return Include(dbSet, includeProperties);
        }

        private IQueryable<T> Include(IQueryable<T> query, params Expression<Func<T, object>>[] includeProperties)
        {
            query = query.AsSingleQuery();
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        private async Task SaveChangesAsync()
        {
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
