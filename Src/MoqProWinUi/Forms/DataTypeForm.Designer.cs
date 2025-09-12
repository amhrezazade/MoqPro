namespace MoqProWinUi.Forms
{
    partial class DataTypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            grpProperty = new GroupBox();
            btnSet = new Button();
            txtMax = new TextBox();
            label6 = new Label();
            txtMin = new TextBox();
            label5 = new Label();
            txtPropName = new TextBox();
            label4 = new Label();
            comboNuture = new ComboBox();
            label3 = new Label();
            chechIsList = new CheckBox();
            comboTargetType = new ComboBox();
            label2 = new Label();
            lstProps = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClose = new Button();
            btnOK = new Button();
            groupBox1 = new GroupBox();
            txtSample = new TextBox();
            lblError = new Label();
            grpProperty.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // grpProperty
            // 
            grpProperty.Controls.Add(btnSet);
            grpProperty.Controls.Add(txtMax);
            grpProperty.Controls.Add(label6);
            grpProperty.Controls.Add(txtMin);
            grpProperty.Controls.Add(label5);
            grpProperty.Controls.Add(txtPropName);
            grpProperty.Controls.Add(label4);
            grpProperty.Controls.Add(comboNuture);
            grpProperty.Controls.Add(label3);
            grpProperty.Controls.Add(chechIsList);
            grpProperty.Controls.Add(comboTargetType);
            grpProperty.Controls.Add(label2);
            grpProperty.Location = new Point(288, 6);
            grpProperty.Name = "grpProperty";
            grpProperty.Size = new Size(256, 217);
            grpProperty.TabIndex = 2;
            grpProperty.TabStop = false;
            grpProperty.Text = "Property Detail";
            grpProperty.Visible = false;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(67, 175);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(108, 29);
            btnSet.TabIndex = 11;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(176, 74);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(74, 27);
            txtMax.TabIndex = 10;
            txtMax.TextChanged += PropertyChange;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 77);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 9;
            label6.Text = "Max :";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(47, 74);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(74, 27);
            txtMin.TabIndex = 12;
            txtMin.TextChanged += PropertyChange;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 77);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 7;
            label5.Text = "Min :";
            // 
            // txtPropName
            // 
            txtPropName.Location = new Point(67, 26);
            txtPropName.Name = "txtPropName";
            txtPropName.Size = new Size(173, 27);
            txtPropName.TabIndex = 6;
            txtPropName.TextChanged += PropertyChange;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 29);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Name :";
            // 
            // comboNuture
            // 
            comboNuture.FormattingEnabled = true;
            comboNuture.Location = new Point(99, 107);
            comboNuture.Name = "comboNuture";
            comboNuture.Size = new Size(151, 28);
            comboNuture.TabIndex = 4;
            comboNuture.SelectedIndexChanged += comboNuture_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-3, 107);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Type Nature :";
            // 
            // chechIsList
            // 
            chechIsList.AutoSize = true;
            chechIsList.Location = new Point(6, 52);
            chechIsList.Name = "chechIsList";
            chechIsList.Size = new Size(79, 24);
            chechIsList.TabIndex = 2;
            chechIsList.Text = "is a List";
            chechIsList.UseVisualStyleBackColor = true;
            chechIsList.CheckedChanged += PropertyChange;
            // 
            // comboTargetType
            // 
            comboTargetType.FormattingEnabled = true;
            comboTargetType.Location = new Point(47, 141);
            comboTargetType.Name = "comboTargetType";
            comboTargetType.Size = new Size(203, 28);
            comboTargetType.TabIndex = 1;
            comboTargetType.SelectedIndexChanged += PropertyChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 144);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 0;
            label2.Text = "Type";
            // 
            // lstProps
            // 
            lstProps.FormattingEnabled = true;
            lstProps.Location = new Point(12, 39);
            lstProps.Name = "lstProps";
            lstProps.Size = new Size(270, 184);
            lstProps.TabIndex = 3;
            lstProps.SelectedIndexChanged += lstProps_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(112, 229);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(471, 229);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(73, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(403, 229);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(73, 29);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSample);
            groupBox1.Location = new Point(21, 264);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 269);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sample";
            // 
            // txtSample
            // 
            txtSample.Location = new Point(16, 26);
            txtSample.Multiline = true;
            txtSample.Name = "txtSample";
            txtSample.ReadOnly = true;
            txtSample.ScrollBars = ScrollBars.Both;
            txtSample.Size = new Size(501, 237);
            txtSample.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Maroon;
            lblError.Location = new Point(37, 536);
            lblError.Name = "lblError";
            lblError.Size = new Size(18, 20);
            lblError.TabIndex = 11;
            lblError.Text = "...";
            // 
            // DataTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 566);
            Controls.Add(lblError);
            Controls.Add(groupBox1);
            Controls.Add(btnOK);
            Controls.Add(btnClose);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstProps);
            Controls.Add(grpProperty);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "DataTypeForm";
            Text = "Data Type Editor";
            Load += DataTypeForm_Load;
            grpProperty.ResumeLayout(false);
            grpProperty.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private GroupBox grpProperty;
        private ComboBox comboTargetType;
        private Label label2;
        private ListBox lstProps;
        private Button btnAdd;
        private Button btnRemove;
        private CheckBox chechIsList;
        private TextBox txtPropName;
        private Label label4;
        private ComboBox comboNuture;
        private Label label3;
        private TextBox txtMin;
        private Label label5;
        private Button btnClose;
        private Button btnOK;
        private TextBox txtMax;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtSample;
        private Button btnSet;
        private Label lblError;
    }
}