using TaskManager.DAL.Contracts;
using TaskManager.Entities;

namespace TaskManager.DAL.Impl.Repositories
{
    public class WorkTaskCommentRepository : GenericRepository<WorkTaskComment>
    {
        public WorkTaskCommentRepository(TaskManagerDbContext dbContext) : base(dbContext)
        { }
    }
}
