using MoqProWinUi.Model;
using MoqProWinUi.Service;

namespace MoqProWinUi.Forms
{
    public partial class StartupForm : Form
    {
        private readonly LogService _logger;

        public StartupForm()
        {
            _logger = Program.LogService;
            _logger.OnLog += OnLog;
            _logger = Program.LogService;
            InitializeComponent();
        }

        private void OnLog(LogItem logItem)
        {
            lblInfo.Text = logItem.Text;
            Application.DoEvents();
        }

        private async void StartupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
