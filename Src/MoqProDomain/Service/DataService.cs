
namespace MoqProDomain.Service;

using MoqProDomain.Entity;
using MoqProDomain.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DataService
{
    private const string FilePath = "data.json";
    private DatabaseModel _database;

    public DataService()
    {
        if (File.Exists(FilePath))
        {
            var json = File.ReadAllText(FilePath);
            _database = JsonConvert.DeserializeObject<DatabaseModel>(json) ?? new DatabaseModel();
        }
        else
        {
            _database = new DatabaseModel
            {
                Requests = new List<Request>(),
                DataTypes = new List<DataType>()
            };
            Save();
        }
    }

    private void Save()
    {
        var json = JsonConvert.SerializeObject(_database, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(FilePath, json);
    }

    // ---------------------- Request CRUD ----------------------

    public List<Request> GetAllRequests() => _database.Requests;

    public Request? GetRequestById(Guid id) =>
        _database.Requests.FirstOrDefault(r => r.Id == id);

    public void AddRequest(Request request)
    {
        _database.Requests.Add(request);
        Save();
    }

    public void UpdateRequest(Request updated)
    {
        var index = _database.Requests.FindIndex(r => r.Id == updated.Id);
        if (index >= 0)
        {
            _database.Requests[index] = updated;
            Save();
        }
    }

    public void DeleteRequest(Guid id)
    {
        var request = _database.Requests.FirstOrDefault(r => r.Id == id);
        if (request != null)
        {
            _database.Requests.Remove(request);
            Save();
        }
    }

    // ---------------------- DataType CRUD ----------------------

    public List<DataType> GetAllDataTypes() => _database.DataTypes;

    public DataType? GetDataTypeById(Guid id) =>
        _database.DataTypes.FirstOrDefault(d => d.Id == id);

    public void AddDataType(DataType dataType)
    {
        _database.DataTypes.Add(dataType);
        Save();
    }

    public void UpdateDataType(DataType updated)
    {
        var index = _database.DataTypes.FindIndex(d => d.Id == updated.Id);
        if (index >= 0)
        {
            _database.DataTypes[index] = updated;
            Save();
        }
    }

    public void DeleteDataType(Guid id)
    {
        var dataType = _database.DataTypes.FirstOrDefault(d => d.Id == id);
        if (dataType != null)
        {
            _database.DataTypes.Remove(dataType);
            Save();
        }
    }
}

