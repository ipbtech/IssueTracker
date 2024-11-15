namespace TaskManager.Entities.Base
{
    public abstract class BaseItem : BaseItemDated
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
