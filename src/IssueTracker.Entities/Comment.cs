namespace IssueTracker.Entities
{
    public class Comment : BaseItemId
    {
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int IssueId { get; set; }
        public Issue Issue { get; set; }
    }
}
