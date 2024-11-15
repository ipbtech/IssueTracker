namespace TaskManager.Entities.Base
{
    public abstract class BaseItemDated
    {
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime UpdatedDateTimeUTC { get; set; }
    }
}
