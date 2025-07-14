namespace MoqProDomain.Entity
{
    public class Request
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public Guid? InputBodyType { get; set; }
        public Guid OutputBodyType { get; set; }
        public List<DataTypeProperty> InputQueryParams { get; set; }
    }
}
