namespace MoqProWinUi.Forms
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private async void StartupForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            Close();
        }
    }
}
