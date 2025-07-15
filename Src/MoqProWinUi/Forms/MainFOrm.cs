using BrightIdeasSoftware;
using MoqProDomain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoqProWinUi.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartupForm startupForm = new StartupForm();
            //startupForm.ShowDialog();         
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            Text = "MOQ PRO version " + fvi.FileVersion;
            tab.Dock = DockStyle.Fill;

            var moq = DataType.GetMOQ().Select(x => new DataTypeViewModel()
            {
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            ObjectListView objectListView = 
                ListViewMaker.CreateListView(moq);

            objectListView.Size = new Size(400, 400);
            objectListView.Dock = DockStyle.Fill;


            typeMainPanel.Controls.Add(objectListView);
        }
    }
}
