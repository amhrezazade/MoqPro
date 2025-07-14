namespace MoqProDomain.Entity;

public class DataTypeProperty
{
    /// <summary>
    /// Name of the property
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Indicates if the property is a list of items or a single item
    /// </summary>
    public bool IsList { get; set; }
    /// <summary>
    /// Nature of the data type for this property
    /// </summary>
    public DataTypeNature Nature { get; set; }
    /// <summary>
    /// This is used to reference a specific <see cref="DataType"/> if the natur is <see cref="DataTypeNature.Object"/>
    /// </summary>
    public Guid? DataTypeNatureId { get; set; }
}
