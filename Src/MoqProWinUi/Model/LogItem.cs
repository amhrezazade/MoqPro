namespace MoqProWinUi.Model;

public class LogItem
{
    public string Text { get; set; }
    public DateTime Date { get; set; }
    public bool MessageBox { get; set; }
    public LogType Type { get; set; }

    public override string ToString()
    {
        string icon = Type switch
        {
            LogType.Info => "❕",
            LogType.Error => "❌",
            LogType.Trace => "🔹",
            _ => ""
        };

        string time = Date.ToShortTimeString();
        return $"{time} {icon} {Text}";
    }
}

