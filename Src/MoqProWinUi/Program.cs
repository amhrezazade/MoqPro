
using MoqProDomain.Service;
using MoqProWinUi.Forms;
using MoqProWinUi.Model;
using MoqProWinUi.Service;
using Newtonsoft.Json;

namespace MoqProWinUi;

public static class Program
{
    public static MainForm MainForm;
    public static LogService LogService;
    public static AppConfig AppConfig;
    public static DataService DataService;

    [STAThread]
    public static void Main()
    {
        ApplicationConfiguration.Initialize();
        if(InitObjects())
            Application.Run(MainForm);
    }


    private static bool InitObjects()
    {
        LogService = new LogService();
        var startupForm = new StartupForm();
        startupForm.Show();

        LogService.Trace("loading main window");
        MainForm = new MainForm();

        LogService.Trace("loading config");
        try
        {
            string content = File.ReadAllText("config.json");
            AppConfig = JsonConvert.DeserializeObject<AppConfig>(content);
        }
        catch (Exception ex)
        {
            LogService.Error("The file config.json is not valid or not accessable", ex);
            return false;
        }

        LogService.Trace("loading data");
        try
        {
            DataService = new DataService();
        }
        catch(Exception ex)
        {
            LogService.Error("ERROR LOADING DATABASE", ex);
            return false;
        }




        //Thread.Sleep(1000);
        LogService.LogTrace = AppConfig.Trace;
        startupForm.Close();
        return true;
    }
}