using System.ComponentModel.DataAnnotations;

namespace IssueTracker.ViewModels
{
    public abstract class IssueVM
    {

        [Required]
        [MaxLength(150, ErrorMessage = "Not more 150 letters")]
        public string Title { get; set; }

        [MaxLength(255, ErrorMessage = "Not more 255 letters")]
        public string? Description { get; set; }
    }
    
    public class IssueGetVM : IssueVM
    {
        public int Id { get; set; }
        public StatusGetVM Status { get; set; }
        public string Author { get; set; }

        public string CreatedDateTime { get; set; }
        public string ClosedDateTime { get; set; }
        public string PlannedDateTime { get; set; }
        public string FactedTimeSpan { get; set; }
    }

    public class IssueCreateVM : IssueVM
    {
        public DateTime? PlannedDateTime { get; set; }
        public double? FactedTimeSpan { get; set; }
    }

    public class IssueUpdateVM : IssueCreateVM
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
    }
}
