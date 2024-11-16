using TaskManager.DAL.Contracts;
using TaskManager.Entities;

namespace TaskManager.DAL.Impl.Repositories
{
    public class WorkTaskRepository : GenericRepository<WorkTask>, IWorkTaskRepository
    {
        public WorkTaskRepository(TaskManagerDbContext dbContext) : base(dbContext)
        { }
    }
}
