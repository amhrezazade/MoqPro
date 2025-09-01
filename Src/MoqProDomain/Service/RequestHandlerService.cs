using MoqProDomain.Entity;

namespace MoqProDomain.Service;

public class RequestHandlerService(DataService dataService)
{
    private static readonly Random _random = new();

    public bool CanHandlePath(string path)
    {
        return dataService.GetAllRequests().Any(r => string.Equals(r.Path, path, StringComparison.OrdinalIgnoreCase));
    }

    public object Handle(string path)
    {
        var request = FindMatchingRequest(path);
        if (request == null) return null;

        var outputType = dataService.GetDataTypeById(request.OutputBodyType);
        if (outputType == null) return null;

        return GenerateMockObject(outputType);
    }

    private Request FindMatchingRequest(string path)
    {
        return dataService.GetAllRequests()
            .FirstOrDefault(r => string.Equals(r.Path, path, StringComparison.OrdinalIgnoreCase));
    }

    private object GenerateMockObject(DataType dataType)
    {
        var result = new Dictionary<string, object>();

        foreach (var prop in dataType.Properties)
        {
            result[prop.Name] = GenerateMockValue(prop);
        }

        return result;
    }

    private object GenerateMockValue(DataTypeProperty property)
    {
        if (property.IsList)
        {

            int count = _random.Next(2, 5); // Generates 2 to 4 items
            var list = new List<object>();

            for (int i = 0; i < count; i++)
            {
                list.Add(GeneratePrimitiveOrObject(property));
            }

            return list;
        }
        else
        {
            return GeneratePrimitiveOrObject(property);
        }
    }

    private object GeneratePrimitiveOrObject(DataTypeProperty prop)
    {
        switch (prop.Nature)
        {
            case DataTypeNature.String:
                return GenerateRandomString(8);

            case DataTypeNature.Int:
                return _random.Next(1, 1000);

            case DataTypeNature.Double:
                return Math.Round(_random.NextDouble() * 1000, 2);

            case DataTypeNature.DateTime:
                return GenerateRandomDate();

            case DataTypeNature.Object:
                if (prop.DataTypeNatureId.HasValue)
                {
                    var refType = dataService.GetDataTypeById(prop.DataTypeNatureId.Value);
                    if (refType != null)
                        return GenerateMockObject(refType);
                }
                return null;

            default:
                return null;
        }
    }

    private string GenerateRandomString(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[_random.Next(s.Length)]).ToArray());
    }

    private DateTime GenerateRandomDate()
    {
        var start = new DateTime(2000, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(_random.Next(range)).AddHours(_random.Next(0, 24)).AddMinutes(_random.Next(0, 60));
    }

}

