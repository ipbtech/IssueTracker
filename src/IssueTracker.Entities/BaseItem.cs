namespace IssueTracker.Entities
{
    public abstract class BaseItemDated
    {
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime UpdatedDateTimeUTC { get; set; }
    }

    public abstract class BaseItemId : BaseItemDated
    {
        public int Id { get; set; }
    }

    public abstract class BaseItemNamed : BaseItemId
    {
        public string Name { get; set; }
    }
}
