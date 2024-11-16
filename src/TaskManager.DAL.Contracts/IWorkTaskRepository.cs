using TaskManager.Entities;
using TaskManager.Entities.Views;

namespace TaskManager.DAL.Contracts
{
    public interface IWorkTaskRepository : IRepository<WorkTask>
    {
        public Task<IEnumerable<WorkTaskView>> GetWorkTaskTableViewsAsync(int count, int page, int sortType);
    }
}
