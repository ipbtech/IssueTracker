using TaskManager.Entities.Base;

namespace TaskManager.Entities
{
    public class WorkTask : BaseItem
    {
        public string Description { get; set; }
        public DateTime? CompletedDateTimeUTC { get; set; }
        public DateTime? ClosedDateTimeUTC { get; set; }
        public TimeSpan? FactedTimeSpan { get; set; }

        public int StatusId { get; set; }
        public WorkTaskStatus Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<WorkTaskComment> Comments { get; set; } = [];
    }
}
