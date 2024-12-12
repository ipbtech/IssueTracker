namespace IssueTracker.Entities
{
    public class Status : BaseItemNamed
    {
        public ICollection<Issue> Issues { get; set; } = [];
    }
}
