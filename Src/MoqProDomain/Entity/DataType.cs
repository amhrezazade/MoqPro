namespace MoqProDomain.Entity;

public class DataType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsList { get; set; }
    public DataTypeNature Nature { get; set; }
    public int? ReferenceId { get; set; }
}

public enum DataTypeNature
{
    String,
    Int,
    Double,
    DateTime,
    Object
}
