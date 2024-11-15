using Microsoft.AspNetCore.Identity;

namespace TaskManager.Entities
{
    public class User : IdentityUser<int>
    {
        public string DisplayName { get; set; }
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime UpdatedDateTimeUTC { get; set; }

        public ICollection<WorkTask> Tasks { get; set; } = [];
        public ICollection<WorkTaskComment> Comments { get; set; } = [];
    }
}
