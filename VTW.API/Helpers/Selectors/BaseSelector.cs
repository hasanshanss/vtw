namespace VTW.API.Helpers.Selectors
{
    public abstract class BaseSelector<T>
    {
        public DateTime ByDate { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public T Id { get; set; }
    }
}
