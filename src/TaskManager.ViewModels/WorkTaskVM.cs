namespace TaskManager.ViewModels
{
    public class WorkTaskVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public WorkTaskStatusVM Status { get; set; }
        public string Author { get; set; }

        public string CreatedDateTimeUTC { get; set; }
        public string ClosedDateTimeUTC { get; set; }
        public string PlannedDateTimeUTC { get; set; }
        public string FactedTimeSpan { get; set; }
    }
}
