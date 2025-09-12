using MoqProDomain.Entity;
using MoqProDomain.Service;
using MoqProWinUi.Service;
using Newtonsoft.Json;
using DataType = MoqProDomain.Entity.DataType;

namespace MoqProWinUi.Forms
{
    public partial class DataTypeForm : Form
    {
        private readonly DataType[] _allTypes;
        private readonly RequestHandlerService _requestHandlerService;
        private readonly LogService _logger;
        public DataTypeForm()
        {
            _requestHandlerService = new(Program.DataService);
            _logger = Program.LogService;
            _allTypes = Program.DataService.DataBase.DataTypes.ToArray();
            DataType = new();
            InitializeComponent();
        }

        public DataType DataType { set; get; }

        private void DataTypeForm_Load(object sender, EventArgs e)
        {
            DataTypeNature[] items =
                [
                 DataTypeNature.DateTime,
                 DataTypeNature.String,
                 DataTypeNature.Int,
                 DataTypeNature.Double,
                 DataTypeNature.Object,
                ];

            comboNuture.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTargetType.DropDownStyle = ComboBoxStyle.DropDownList;

            comboNuture.DataSource = items;
            comboTargetType.DataSource = _allTypes;
            lstProps.DataSource = DataType.Properties;
            object mock = _requestHandlerService.GenerateMockObject(DataType);
            txtSample.Text = JsonConvert.SerializeObject(mock, Formatting.Indented);
            txtName.Text = DataType.Name;
            lstProps.DataSource = DataType.Properties;
        }

        private void RefreshData()
        {
            var x = lstProps.DataSource;
            lstProps.DataSource = null;
            lstProps.DataSource = x;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new DataTypeProperty();
            DataType.Properties.Add(item);
            RefreshData();
        }

        private void lstProps_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTypeProperty item = GetSelected();
            if (item is null)
            {
                grpProperty.Visible = false;
                return;
            }

            comboNuture.SelectedItem = item.Nature;
            comboTargetType.Visible = item.Nature == DataTypeNature.Object;
            if (item.DataTypeNatureId is not null)
                comboTargetType.SelectedItem = _allTypes.FirstOrDefault(x => x.Id == item.DataTypeNatureId);
            grpProperty.Visible = true;
            txtMax.Text = item.MaxLen.ToString();
            txtMin.Text = item.MinLen.ToString();
            txtPropName.Text = item.Name;
            chechIsList.Checked = item.IsList;

            btnSet.Enabled = false;

            txtMax.BackColor = Color.White;
            txtMin.BackColor = Color.White;
            txtPropName.BackColor = Color.White;
            comboNuture.BackColor = Color.White;
            comboTargetType.BackColor = Color.White;
            chechIsList.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Refresh();
            grpProperty.Visible = false;
        }


        private DataTypeProperty GetSelected()
        {
            if (lstProps.Items.Count == 0)
                return null;

            if (lstProps.SelectedIndex < 0)
                return null;

            return lstProps.SelectedItem as DataTypeProperty;
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            DataTypeProperty item = GetSelected();
            if (item is null)
                return;

            item.IsList = chechIsList.Checked;

            DataType.Name = txtName.Text;

            item.Name = txtPropName.Text;

            int x;
            if (int.TryParse(txtMax.Text, out x))
            {
                item.MaxLen = x;
            }
            else
            {
                txtMax.Text = item.MaxLen.ToString();
            }

            if (int.TryParse(txtMin.Text, out x))
            {
                item.MinLen = x;
            }
            else
            {
                txtMin.Text = item.MinLen.ToString();
            }

            item.Nature = (DataTypeNature)comboNuture.SelectedItem;


            if (item.Nature == DataTypeNature.Object)
            {
                if (item.DataTypeNatureId is null)
                {
                    var type = _allTypes.FirstOrDefault();
                    if (type is null)
                    {
                        item.Nature = DataTypeNature.String;
                        comboNuture.SelectedItem = item.Nature;
                        return;
                    }
                    item.DataTypeNatureId = type.Id;
                    comboTargetType.SelectedItem = type;
                }
                comboTargetType.Visible = true;
                item.DataTypeNatureId = ((DataType)comboTargetType.SelectedItem).Id;

            }
            else
                comboTargetType.Visible = false;

            item.Name = txtPropName.Text;

            object mock = _requestHandlerService.GenerateMockObject(DataType);
            txtSample.Text = JsonConvert.SerializeObject(mock, Formatting.Indented);
            RefreshData();
            lstProps_SelectedIndexChanged(sender, e);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataType.Name = txtName.Text;
        }

        private void comboNuture_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTypeProperty item = GetSelected();
            if (item is null)
                return;

            var nature = (DataTypeNature)comboNuture.SelectedItem;

            if (nature == DataTypeNature.Object)
            {
                if (item.DataTypeNatureId is null)
                {
                    var type = _allTypes.FirstOrDefault();
                    if (type is null)
                    {
                        comboNuture.SelectedItem = DataTypeNature.String;
                        return;
                    }
                    comboTargetType.SelectedItem = type;
                }
                comboTargetType.Visible = true;
            }
            else
                comboTargetType.Visible = false;

            PropertyChange(sender, e);
        }

        private void PropertyChange(object sender, EventArgs e)
        {
            btnSet.Enabled = true;
            if (sender is not null)
            {
                if(sender is Control control)
                    control.BackColor = Color.LightSkyBlue;
            }
        }
    }
}
