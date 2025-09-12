using MoqProDomain.Entity;
using MoqProDomain.Model;
using MoqProDomain.Service;
using MoqProWinUi.Extensions;
using MoqProWinUi.Model;
using MoqProWinUi.Service;

namespace MoqProWinUi.Forms
{
    public partial class MainForm : Form
    {
        private readonly LogService _logger;
        private readonly DataService _db;
        public MainForm()
        {
            _logger = Program.LogService;
            _logger.OnLog += OnLog;
            _db = Program.DataService;
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
            lstTypes.DataSource = _db.DataBase.DataTypes;


            // config request list:
            _logger.Info("application started");

            //this.SetDarkModee(true);

            RefreshData();
        }


        private void RefreshData()
        {
            lstTypes.DataSource = null;
            lstTypes.DataSource = _db.DataBase.DataTypes;
            Application.DoEvents();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            DataTypeForm frm = new DataTypeForm();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            _db.DataBase.DataTypes.Add(frm.DataType);
            _db.Save();
            RefreshData();
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (lstTypes.Items.Count == 0)
                return;

            if (lstTypes.SelectedIndex < 0)
                return;

            var item = (DataType)lstTypes.SelectedItem;

            DataTypeForm frm = new();
            frm.DataType = item.Copy();

            if (frm.ShowDialog() != DialogResult.OK)
                return;

            item.Properties = frm.DataType.Properties;
            item.Name = frm.DataType.Name;
            item.Description = frm.DataType.Description;

            _db.Save();
            RefreshData();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(!_db.HasChanges)
                return;

            _logger.Info("database changed outside of app. data reloaded !");
            RefreshData();
            _db.HasChanges = false;
        }
    }
}
