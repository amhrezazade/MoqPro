namespace MoqProDomain.Entity;

public class DataType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<DataTypeProperty> Properties { get; set; }

    public static List<DataType> GetMOQ()
    {
        return new List<DataType>
        {
            new DataType
            {
                Id = Guid.NewGuid(),
                Name = "User",
                Description = "Represents a user in the system",
                Properties = new List<DataTypeProperty>
                {
                    new DataTypeProperty { Name = "Username", IsList = false, Nature = DataTypeNature.String },
                    new DataTypeProperty { Name = "BirthDate", IsList = false, Nature = DataTypeNature.DateTime },
                    new DataTypeProperty { Name = "Roles", IsList = true, Nature = DataTypeNature.String }
                }
            },
            new DataType
            {
                Id = Guid.NewGuid(),
                Name = "Product",
                Description = "Details about a product",
                Properties = new List<DataTypeProperty>
                {
                    new DataTypeProperty { Name = "Name", IsList = false, Nature = DataTypeNature.String },
                    new DataTypeProperty { Name = "Price", IsList = false, Nature = DataTypeNature.Double },
                    new DataTypeProperty { Name = "Categories", IsList = true, Nature = DataTypeNature.String }
                }
            },
            new DataType
            {
                Id = Guid.NewGuid(),
                Name = "Order",
                Description = "Customer order details",
                Properties = new List<DataTypeProperty>
                {
                    new DataTypeProperty { Name = "OrderDate", IsList = false, Nature = DataTypeNature.DateTime },
                    new DataTypeProperty { Name = "TotalAmount", IsList = false, Nature = DataTypeNature.Double },
                    new DataTypeProperty { Name = "Items", IsList = true, Nature = DataTypeNature.Object, DataTypeNatureId = Guid.NewGuid() }
                }
            },
            new DataType
            {
                Id = Guid.NewGuid(),
                Name = "Invoice",
                Description = "Invoice record for an order",
                Properties = new List<DataTypeProperty>
                {
                    new DataTypeProperty { Name = "InvoiceNumber", IsList = false, Nature = DataTypeNature.String },
                    new DataTypeProperty { Name = "CreatedAt", IsList = false, Nature = DataTypeNature.DateTime },
                    new DataTypeProperty { Name = "Lines", IsList = true, Nature = DataTypeNature.Object, DataTypeNatureId = Guid.NewGuid() }
                }
            },
            new DataType
            {
                Id = Guid.NewGuid(),
                Name = "Customer",
                Description = "Customer personal and contact info",
                Properties = new List<DataTypeProperty>
                {
                    new DataTypeProperty { Name = "FullName", IsList = false, Nature = DataTypeNature.String },
                    new DataTypeProperty { Name = "Email", IsList = false, Nature = DataTypeNature.String },
                    new DataTypeProperty { Name = "Addresses", IsList = true, Nature = DataTypeNature.Object, DataTypeNatureId = Guid.NewGuid() }
                }
            }
        };
    }


}
