namespace TaskManager.Entities
{
    public class WorkTaskComment : BaseItemId
    {
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int TaskId { get; set; }
        public WorkTask Task { get; set; }
    }
}
