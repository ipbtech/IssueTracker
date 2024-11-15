using TaskManager.Entities.Base;

namespace TaskManager.Entities
{
    public class WorkTaskStatus : BaseItem
    {
        public ICollection<WorkTask> Tasks { get; set; } = [];
    }
}
