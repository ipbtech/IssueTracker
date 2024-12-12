using IssueTracker.Entities;

namespace IssueTracker.DAL.Impl.Repositories.Concrete
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(IssueTrackerDbContext dbContext) : base(dbContext)
        { }
    }
}
