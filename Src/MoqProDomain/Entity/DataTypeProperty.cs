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

    /// <summary>
    /// minimum len of object; works for string, numbers and list
    /// </summary>
    public int MinLen { get; set; }

    /// <summary>
    /// maximum len of object; works for string, numbers and list
    /// </summary>
    public int MaxLen { get; set; }

    public DataTypeProperty Copy()
    {
        DataTypeProperty copy = new DataTypeProperty();
        copy.Name = Name;
        copy.IsList = IsList;
        copy.Nature = Nature;
        copy.DataTypeNatureId = DataTypeNatureId;
        copy.MinLen = MinLen;
        copy.MaxLen = MaxLen;
        return copy;
    }

    public DataTypeProperty()
    {
        Name = "new property";
        IsList = false;
        Nature = DataTypeNature.String;
        DataTypeNatureId = null;
        MinLen = 1;
        MaxLen = 10;
    }

    public override string ToString()
    {
        return Name;
    }
}
