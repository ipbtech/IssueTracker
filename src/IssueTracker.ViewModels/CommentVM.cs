namespace IssueTracker.ViewModels
{
    public class CommentGetVM : CommentCreateVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CreatedDateTime { get; set; }
    }

    public class CommentCreateVM
    {
        public int IssueId { get; set; }
        public string Content { get; set; }
    }
}
