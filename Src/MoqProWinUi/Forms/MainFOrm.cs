using MoqProWinUi.Model;
using MoqProWinUi.Service;

namespace MoqProWinUi.Forms
{
    public partial class MainForm : Form
    {
        private readonly LogService _logger;
        public MainForm()
        {
            _logger = Program.LogService;
            _logger.OnLog += OnLog;
            InitializeComponent();
        }

        private void OnLog(LogItem logItem)
        {
            txtLog.Text += logItem.ToString() + "\r\n";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            _logger.Trace("config env");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            Text = "MOQ PRO version " + fvi.FileVersion;
            tab.Dock = DockStyle.Fill;
            txtLog.Dock = DockStyle.Fill;
            lstRequests.Dock = DockStyle.Fill;
            lstTypes.Dock = DockStyle.Fill;

            // config request list:
            _logger.Info("application started");
        }



    }
}
