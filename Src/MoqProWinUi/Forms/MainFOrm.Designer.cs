namespace MoqProWinUi.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tab = new TabControl();
            equestTab = new TabPage();
            textBox1 = new TextBox();
            label1 = new Label();
            requestList = new ListBox();
            typeTab = new TabPage();
            tyoeList = new ListBox();
            serverTab = new TabPage();
            tab.SuspendLayout();
            equestTab.SuspendLayout();
            typeTab.SuspendLayout();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(equestTab);
            tab.Controls.Add(typeTab);
            tab.Controls.Add(serverTab);
            tab.Location = new Point(10, 9);
            tab.Margin = new Padding(3, 2, 3, 2);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(829, 426);
            tab.TabIndex = 0;
            // 
            // equestTab
            // 
            equestTab.Controls.Add(textBox1);
            equestTab.Controls.Add(label1);
            equestTab.Controls.Add(requestList);
            equestTab.Location = new Point(4, 24);
            equestTab.Margin = new Padding(3, 2, 3, 2);
            equestTab.Name = "equestTab";
            equestTab.Padding = new Padding(3, 2, 3, 2);
            equestTab.Size = new Size(821, 398);
            equestTab.TabIndex = 0;
            equestTab.Text = "Requests";
            equestTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 4);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 6);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Path";
            // 
            // requestList
            // 
            requestList.FormattingEnabled = true;
            requestList.ItemHeight = 15;
            requestList.Location = new Point(5, 4);
            requestList.Margin = new Padding(3, 2, 3, 2);
            requestList.Name = "requestList";
            requestList.Size = new Size(285, 394);
            requestList.TabIndex = 0;
            // 
            // typeTab
            // 
            typeTab.Controls.Add(tyoeList);
            typeTab.Location = new Point(4, 24);
            typeTab.Margin = new Padding(3, 2, 3, 2);
            typeTab.Name = "typeTab";
            typeTab.Padding = new Padding(3, 2, 3, 2);
            typeTab.Size = new Size(821, 398);
            typeTab.TabIndex = 1;
            typeTab.Text = "Types";
            typeTab.UseVisualStyleBackColor = true;
            // 
            // tyoeList
            // 
            tyoeList.FormattingEnabled = true;
            tyoeList.ItemHeight = 15;
            tyoeList.Location = new Point(573, 4);
            tyoeList.Margin = new Padding(3, 2, 3, 2);
            tyoeList.Name = "tyoeList";
            tyoeList.Size = new Size(243, 394);
            tyoeList.TabIndex = 0;
            // 
            // serverTab
            // 
            serverTab.Location = new Point(4, 24);
            serverTab.Margin = new Padding(3, 2, 3, 2);
            serverTab.Name = "serverTab";
            serverTab.Size = new Size(821, 398);
            serverTab.TabIndex = 2;
            serverTab.Text = "Server";
            serverTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 436);
            Controls.Add(tab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tab.ResumeLayout(false);
            equestTab.ResumeLayout(false);
            equestTab.PerformLayout();
            typeTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage equestTab;
        private ListBox requestList;
        private TabPage typeTab;
        private TabPage serverTab;
        private Label label1;
        private TextBox textBox1;
        private ListBox tyoeList;
    }
}