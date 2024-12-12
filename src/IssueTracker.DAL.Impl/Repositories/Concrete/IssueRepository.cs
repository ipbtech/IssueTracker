using IssueTracker.DAL.Contracts;
using IssueTracker.Entities;
using IssueTracker.Entities.Projections;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.DAL.Impl.Repositories.Concrete
{
    public class IssueRepository : GenericRepository<Issue>, IIssueRepository
    {
        public IssueRepository(IssueTrackerDbContext dbContext) : base(dbContext)
        { }

        public async Task<IEnumerable<IssueView>> GetWorkTaskTableViewsAsync(int count, int page, int sort, int? userFilter, int? statusFilter)
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

            var views = await query.Select(task => new IssueView
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
