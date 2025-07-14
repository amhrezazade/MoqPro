using MoqProDomain.Entity;

namespace MoqProDomain.Model
{
    public class DatabaseModel
    {
        public List<Request> Requests { get; set; }
        public List<DataType> DataTypes { get; set; }
    }
}
