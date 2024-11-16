namespace TaskManager.Entities
{
    public class WorkTaskStatus : BaseItemNamed
    {
        public ICollection<WorkTask> Tasks { get; set; } = [];
    }
}
