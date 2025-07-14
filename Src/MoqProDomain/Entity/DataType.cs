namespace MoqProDomain.Entity;

public class DataType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<DataTypeProperty> Properties { get; set; }
}
