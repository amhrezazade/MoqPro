using MoqProDomain.Entity;
using MoqProDomain.Model;

namespace MoqProDomain.Service;

public class RequestHandlerService(DataService dataService)
{
    private readonly DatabaseModel _db = dataService.DataBase;
    private static readonly Random _random = new();

    public bool CanHandlePath(string path)
    {
        return dataService.DataBase.Requests.Any(r => string.Equals(r.Path, path, StringComparison.OrdinalIgnoreCase));
    }

    public object Handle(string path, string method)
    {
        var request = FindMatchingRequest(path);
        if (request == null) return null;

        var outputType = _db.DataTypes.FirstOrDefault(x => x.Id == request.OutputBodyType);
        if (outputType == null) return null;

        return GenerateMockObject(outputType);
    }

    private Request FindMatchingRequest(string path)
    {
        return _db.Requests
            .FirstOrDefault(r => string.Equals(r.Path, path, StringComparison.OrdinalIgnoreCase));
    }

    public object GenerateMockObject(DataType dataType,int callDepth = 0)
    {
        if (callDepth > 3)
            return null;

        var result = new Dictionary<string, object>();

        foreach (var prop in dataType.Properties)
        {
            result[prop.Name] = GenerateMockValue(prop, callDepth);
        }

        return result;
    }

    private object GenerateMockValue(DataTypeProperty property, int callDepth)
    {
        if (property.IsList)
        {

            int count = _random.Next(property.MinLen, property.MaxLen); 
            var list = new List<object>();

            for (int i = 0; i < count; i++)
            {
                list.Add(GeneratePrimitiveOrObject(property, callDepth));
            }

            return list;
        }
        else
        {
            return GeneratePrimitiveOrObject(property,callDepth);
        }
    }

    private object GeneratePrimitiveOrObject(DataTypeProperty prop, int callDepth)
    {
        if(prop.MinLen > prop.MaxLen)
            prop.MinLen = prop.MaxLen;
        switch (prop.Nature)
        {
            case DataTypeNature.String:
                return GenerateRandomString(prop.MinLen,prop.MaxLen);

            case DataTypeNature.Int:
                return _random.Next(prop.MinLen, prop.MaxLen);

            case DataTypeNature.Double:
                return Math.Round(_random.NextDouble() * _random.Next(prop.MinLen, prop.MaxLen), 2);

            case DataTypeNature.DateTime:
                return GenerateRandomDate();

            case DataTypeNature.Object:
                if (prop.DataTypeNatureId.HasValue)
                {
                    var refType = _db.DataTypes.FirstOrDefault(x => x.Id == prop.DataTypeNatureId.Value);
                    if (refType != null)
                        return GenerateMockObject(refType, callDepth + 1);
                }
                return null;

            default:
                return null;
        }
    }

    private string GenerateRandomString(int min,int max)
    {
        const string chars = " ab cde fgh ijk lmn pq rs tuvw xy z01 2345 6789";
        return new string(Enumerable.Repeat(chars, _random.Next(min,max))
            .Select(s => s[_random.Next(s.Length)]).ToArray());
    }

    private DateTime GenerateRandomDate()
    {
        var start = new DateTime(2000, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(_random.Next(range)).AddHours(_random.Next(0, 24)).AddMinutes(_random.Next(0, 60));
    }

}

