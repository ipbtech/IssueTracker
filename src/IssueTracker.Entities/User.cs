using Microsoft.AspNetCore.Identity;

namespace IssueTracker.Entities
{
    public class User : IdentityUser<int>
    {
        public string DisplayName { get; set; }
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime UpdatedDateTimeUTC { get; set; }

        public ICollection<Issue> Issues { get; set; } = [];
        public ICollection<Comment> Comments { get; set; } = [];
    }
}
