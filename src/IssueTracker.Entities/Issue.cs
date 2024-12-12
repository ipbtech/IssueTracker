namespace IssueTracker.Entities
{
    public class Issue : BaseItemNamed
    {
        public string? Description { get; set; }
        public DateTime? PlannedDateTimeUTC { get; set; }
        public DateTime? ClosedDateTimeUTC { get; set; }
        public TimeSpan? FactedTimeSpan { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; } = [];
    }
}
