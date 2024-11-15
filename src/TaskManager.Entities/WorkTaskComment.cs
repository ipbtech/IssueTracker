using TaskManager.Entities.Base;

namespace TaskManager.Entities
{
    public class WorkTaskComment : BaseItemDated
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int TaskId { get; set; }
        public WorkTask Task { get; set; }
    }
}
