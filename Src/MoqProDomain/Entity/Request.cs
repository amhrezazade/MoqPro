namespace MoqProDomain.Entity
{
    public class Request
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public Guid OutputBodyType { get; set; }
        public Guid? InputBodyType { get; set; }
        public Guid? InputQueryParams { get; set; }
    }
}
