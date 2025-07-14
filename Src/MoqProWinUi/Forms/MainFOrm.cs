using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoqProWinUi.Forms
{
    public partial class MainFOrm : Form
    {
        private HttpListener? _listener;
        private CancellationTokenSource? _cts;


        public MainFOrm()
        {
            InitializeComponent();
        }

        private void MainFOrm_Load(object sender, EventArgs e)
        {

        }




    }
}
