namespace MoqProDomain.Entity;

public class DataType
{

    public DataType()
    {
        Id = Guid.NewGuid();
        Name = "New Data Type";
        Description = "";
        Properties = [];
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<DataTypeProperty> Properties { get; set; }

    public DataType Copy()
    {
        DataType copy = new();
        copy.Id = Id;
        copy.Name = Name.ToString();
        copy.Description = Description.ToString();
        foreach (DataTypeProperty property in Properties)
        {
            copy.Properties.Add(property.Copy());
        }
        return copy;
    }


    public override string ToString()
    {
        return Name;// + " : " + string.Join(" , ",Properties.Select(x => x.Name));
    }
}
