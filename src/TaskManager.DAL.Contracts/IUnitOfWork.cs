using TaskManager.DAL.Contracts.Repositories;
using TaskManager.Entities;

namespace TaskManager.Contracts
{
    public interface IUnitOfWork
    {   
        public IWorkTaskRepository Tasks { get; set; }
        public IRepository<WorkTaskComment> TaskComments { get; set; }
        public IRepository<WorkTaskStatus> TaskStatuses { get; set; }

        public IDbTransaction TransactionManager { get; set; }
    }
}
