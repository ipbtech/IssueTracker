using IssueTracker.Entities;

namespace IssueTracker.DAL.Impl.Repositories.Concrete
{
    public class StatusRepository : GenericRepository<Status>
    {
        public StatusRepository(IssueTrackerDbContext dbContext) : base(dbContext)
        { }
    }
}
