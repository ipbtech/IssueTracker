using Microsoft.EntityFrameworkCore;
using TaskManager.DAL.Contracts;
using TaskManager.Entities;
using TaskManager.Entities.Views;

namespace TaskManager.DAL.Impl.Repositories
{
    public class WorkTaskRepository : GenericRepository<WorkTask>, IWorkTaskRepository
    {
        public WorkTaskRepository(TaskManagerDbContext dbContext) : base(dbContext)
        { }

        public async Task<IEnumerable<WorkTaskView>> GetWorkTaskTableViewsAsync(int count, int page, int sort, int? userFilter, int? statusFilter)
        {
            var query = dbSet.AsNoTracking();
            // filtering
            if (userFilter is not null)
                query = query.Where(task => task.UserId == userFilter);
            if (statusFilter is not null)
                query = query.Where(task => task.StatusId == statusFilter);
            // sorting
            if (sort == 0)
                query = query.OrderByDescending(task => task.CreatedDateTimeUTC);
            else
                query = query.OrderBy(task => task.CreatedDateTimeUTC);
            // pagination
            query = query.Skip((page - 1) * count).Take(count);

            var views = await query.Select(task => new WorkTaskView
            {
                Id = task.Id,
                Title = task.Name,
                Status = task.Status.Name,
                Author = task.User.UserName,
                CreatedDateTimeUTC = task.CreatedDateTimeUTC,
                ClosedDateTimeUTC = task.ClosedDateTimeUTC,
                FactedTimeSpan = task.FactedTimeSpan,
            }).ToListAsync();
            return views;
        }
    }
}
