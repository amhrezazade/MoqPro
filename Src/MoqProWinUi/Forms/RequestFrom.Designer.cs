namespace MoqProWinUi.Forms
{
    partial class RequestFrom
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
            lblError = new Label();
            txtRout = new TextBox();
            groupBox1 = new GroupBox();
            comQuery = new ComboBox();
            comBody = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            chInput = new CheckBox();
            btnok = new Button();
            btnClose = new Button();
            label2 = new Label();
            comOutput = new ComboBox();
            chReturnError = new CheckBox();
            txtReturnError = new TextBox();
            comMethod = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Maroon;
            lblError.Location = new Point(464, 124);
            lblError.Name = "lblError";
            lblError.Size = new Size(18, 20);
            lblError.TabIndex = 1;
            lblError.Text = "...";
            // 
            // txtRout
            // 
            txtRout.Location = new Point(104, 6);
            txtRout.Name = "txtRout";
            txtRout.Size = new Size(496, 27);
            txtRout.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comQuery);
            groupBox1.Controls.Add(comBody);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(chInput);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // comQuery
            // 
            comQuery.DropDownStyle = ComboBoxStyle.DropDownList;
            comQuery.FormattingEnabled = true;
            comQuery.Location = new Point(15, 50);
            comQuery.Name = "comQuery";
            comQuery.Size = new Size(193, 28);
            comQuery.TabIndex = 11;
            // 
            // comBody
            // 
            comBody.DropDownStyle = ComboBoxStyle.DropDownList;
            comBody.FormattingEnabled = true;
            comBody.Location = new Point(215, 50);
            comBody.Name = "comBody";
            comBody.Size = new Size(215, 28);
            comBody.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 9;
            label1.Text = "From Body :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 27);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 8;
            label3.Text = "From Query :";
            // 
            // chInput
            // 
            chInput.AutoSize = true;
            chInput.Location = new Point(15, 0);
            chInput.Name = "chInput";
            chInput.Size = new Size(65, 24);
            chInput.TabIndex = 0;
            chInput.Text = "Input";
            chInput.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            btnok.Location = new Point(543, 147);
            btnok.Name = "btnok";
            btnok.Size = new Size(57, 29);
            btnok.TabIndex = 5;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(464, 147);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(73, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "Output :";
            // 
            // comOutput
            // 
            comOutput.DropDownStyle = ComboBoxStyle.DropDownList;
            comOutput.FormattingEnabled = true;
            comOutput.Location = new Point(80, 44);
            comOutput.Name = "comOutput";
            comOutput.Size = new Size(193, 28);
            comOutput.TabIndex = 8;
            // 
            // chReturnError
            // 
            chReturnError.AutoSize = true;
            chReturnError.Location = new Point(279, 46);
            chReturnError.Name = "chReturnError";
            chReturnError.Size = new Size(110, 24);
            chReturnError.TabIndex = 9;
            chReturnError.Text = "Return Error";
            chReturnError.UseVisualStyleBackColor = true;
            // 
            // txtReturnError
            // 
            txtReturnError.AcceptsTab = true;
            txtReturnError.Location = new Point(395, 43);
            txtReturnError.Name = "txtReturnError";
            txtReturnError.Size = new Size(205, 27);
            txtReturnError.TabIndex = 10;
            // 
            // comMethod
            // 
            comMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comMethod.FormattingEnabled = true;
            comMethod.Location = new Point(12, 5);
            comMethod.Name = "comMethod";
            comMethod.Size = new Size(86, 28);
            comMethod.TabIndex = 11;
            // 
            // RequestFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 182);
            Controls.Add(comMethod);
            Controls.Add(txtReturnError);
            Controls.Add(chReturnError);
            Controls.Add(comOutput);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnok);
            Controls.Add(groupBox1);
            Controls.Add(txtRout);
            Controls.Add(lblError);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RequestFrom";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Request Editor";
            Load += RequestFrom_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblError;
        private TextBox txtRout;
        private GroupBox groupBox1;
        private CheckBox chInput;
        private Button btnok;
        private Button btnClose;
        private Label label2;
        private ComboBox comOutput;
        private Label label3;
        private CheckBox chReturnError;
        private TextBox txtReturnError;
        private ComboBox comMethod;
        private ComboBox comQuery;
        private ComboBox comBody;
        private Label label1;
    }
}