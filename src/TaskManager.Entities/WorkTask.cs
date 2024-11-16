namespace TaskManager.Entities
{
    public class WorkTask : BaseItemNamed
    {
        public string Description { get; set; }
        public DateTime? PlannedDateTimeUTC { get; set; }
        public DateTime? ClosedDateTimeUTC { get; set; }
        public TimeSpan? FactedTimeSpan { get; set; }

        public int StatusId { get; set; }
        public WorkTaskStatus Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<WorkTaskComment> Comments { get; set; } = [];
    }
}
