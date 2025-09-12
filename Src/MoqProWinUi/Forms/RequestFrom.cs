using MoqProDomain.Entity;

namespace MoqProWinUi.Forms
{
    public partial class RequestFrom : Form
    {
        private Request _request;
        private readonly DataType[] _types;
        public RequestFrom(Request request, DataType[] types)
        {
            _request = request;
            _types = types;
            InitializeComponent();
        }

        public Request GetRequest() => _request;

        private void RequestFrom_Load(object sender, EventArgs e)
        {
            
            comMethod.Items.Clear();
            comMethod.Items.Add("GET");
            comMethod.Items.Add("POST");
            comMethod.Items.Add("PUT");
            comMethod.Items.Add("DELETE");

            comOutput.DataSource = _types;
            comQuery.DataSource = _types;
            comBody.DataSource = _types;

            comOutput.DropDownStyle = ComboBoxStyle.DropDownList;
            comQuery.DropDownStyle = ComboBoxStyle.DropDownList;
            comBody.DropDownStyle = ComboBoxStyle.DropDownList;

            comMethod.Text = _request.Method;
            txtRout.Text = _request.Path;

        }
    }
}
