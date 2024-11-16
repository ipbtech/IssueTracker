namespace TaskManager.ViewModels
{
    public class WorkTaskTableVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public string CreatedDateTimeUTC { get; set; }
        public string ClosedDateTimeUTC { get; set; }
        public string FactedTimeSpan { get; set; }
    }
}
