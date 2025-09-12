
namespace MoqProDomain.Service;

using MoqProDomain.Entity;
using MoqProDomain.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class DataService
{
    private FileInfo _file;
    private Timer _timer;
    private FileSystemWatcher _watcher;


    public bool HasChanges { set; get; } = false;
    public DatabaseModel DataBase { set; get; }


    private async void DoWork(object state)
    {



    }

    public void Init()
    {
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(10));
        _file = new FileInfo("data.json");
        if (_file.Exists)
        {
            var json = File.ReadAllText(_file.FullName);

            var db = JsonConvert.DeserializeObject<DatabaseModel>(json) ?? new DatabaseModel();
            if (DataBase is null)
                DataBase = db;
            else
            {
                DataBase.DataTypes = db.DataTypes;
                DataBase.Requests = db.Requests;
            }
        }
        else
        {
            DataBase = new DatabaseModel
            {
                Requests = new List<Request>(),
                DataTypes = new List<DataType>()
            };
            Save();
        }
        _watcher = new(_file.Directory.FullName);
        _watcher.Filter = _file.Name;
        _watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
        _watcher.Changed += OnFileChanged;
        _watcher.EnableRaisingEvents = true;
    }

    private void OnFileChanged(object sender, FileSystemEventArgs e)
    {
        Thread.Sleep(100);
        var json = File.ReadAllText(_file.FullName);
        var db = JsonConvert.DeserializeObject<DatabaseModel>(json) ?? new DatabaseModel();
        if (DataBase.Gethash() != db.Gethash())
        {
            DataBase.DataTypes = db.DataTypes;
            DataBase.Requests = db.Requests;
            HasChanges = true;
        }
    }

    public void Save()
    {
        var json = JsonConvert.SerializeObject(DataBase, Formatting.Indented);
        File.WriteAllText(_file.FullName, json);
    }
}

