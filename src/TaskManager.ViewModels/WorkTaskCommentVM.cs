namespace TaskManager.ViewModels
{
    public class WorkTaskCommentGetVM : WorkTaskCommentCreateVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CreatedDateTime { get; set; }
    }

    public class WorkTaskCommentCreateVM
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
    }
}
