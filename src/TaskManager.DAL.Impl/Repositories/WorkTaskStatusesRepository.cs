using TaskManager.Entities;

namespace TaskManager.DAL.Impl.Repositories
{
    public class WorkTaskStatusesRepository : GenericRepository<WorkTaskStatus>
    {
        public WorkTaskStatusesRepository(TaskManagerDbContext dbContext) : base(dbContext)
        { }
    }
}
