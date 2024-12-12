namespace IssueTracker.ViewModels
{
    public class IssueTableRowVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public string CreatedDateTime { get; set; }
        public string ClosedDateTime { get; set; }
        public string FactedTimeSpan { get; set; }
    }
}
