
using MoqProWinUi.Model;

namespace MoqProWinUi.Service;

public delegate void OnLogDlegate(LogItem logItem);

public class LogService
{
    public bool LogTrace { get; set;  } = true;

    public event OnLogDlegate OnLog;

    public void Info(string message,bool messageBox = false)
    {
        var item =  new LogItem()
        {
            Text = message,
            MessageBox = messageBox,
            Date = DateTime.Now,
            Type = LogType.Info,
        };
        OnLog(item);

        if (messageBox)
            MessageBox.Show(message,"information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void Trace(string message)
    {
        var item = new LogItem()
        {
            Text = message,
            MessageBox = false,
            Date = DateTime.Now,
            Type = LogType.Trace,
        };
        OnLog(item);
    }


    public void Error(string message, Exception exception = null, bool messageBox = true)
    {
        var item = new LogItem()
        {
            Text = message,
            MessageBox = messageBox,
            Date = DateTime.Now,
            Type = LogType.Error,
        };

        OnLog(item);

        if(!messageBox)
            return;

        string msg = message;
        if (exception != null) 
        {
            msg = msg + " :\r\n" + exception.Message;
        }

        MessageBox.Show(msg,"Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }


}

