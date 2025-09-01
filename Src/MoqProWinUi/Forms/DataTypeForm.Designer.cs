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
            lblName = new TextBox();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
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
            // lblName
            // 
            lblName.Location = new Point(74, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(208, 27);
            lblName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(288, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 252);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Property Detail";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 184);
            listBox1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(112, 229);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 0;
            label2.Text = "Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 59);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "is a List";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(173, 28);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 3;
            label3.Text = "Target Type :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 6;
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
            // DataTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 264);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "DataTypeForm";
            Text = "Data Type Editor";
            Load += DataTypeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lblName;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label2;
        private ListBox listBox1;
        private Button btnAdd;
        private Button btnRemove;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
    }
}