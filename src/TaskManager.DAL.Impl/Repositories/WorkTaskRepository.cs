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

        public async Task<IEnumerable<WorkTaskView>> GetWorkTaskTableViewsAsync(int count, int page, int sort)
        {
            var query = await dbSet.OrderByDescending(task => task.CreatedDateTimeUTC)
                .Select(task => new WorkTaskView
                {
                    Id = task.Id,
                    Title = task.Name,
                    Status = task.Status.Name,
                    Author = task.User.UserName,
                    CreatedDateTimeUTC = task.CreatedDateTimeUTC,
                    ClosedDateTimeUTC = task.ClosedDateTimeUTC,
                    FactedTimeSpan = task.FactedTimeSpan,
                }).ToListAsync();
            return query;
        }
    }
}
