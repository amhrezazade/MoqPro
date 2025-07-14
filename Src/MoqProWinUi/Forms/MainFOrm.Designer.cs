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
            requestList = new ListBox();
            typeTab = new TabPage();
            serverTab = new TabPage();
            label1 = new Label();
            textBox1 = new TextBox();
            tyoeList = new ListBox();
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
            tab.Location = new Point(12, 12);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(947, 568);
            tab.TabIndex = 0;
            // 
            // equestTab
            // 
            equestTab.Controls.Add(textBox1);
            equestTab.Controls.Add(label1);
            equestTab.Controls.Add(requestList);
            equestTab.Location = new Point(4, 29);
            equestTab.Name = "equestTab";
            equestTab.Padding = new Padding(3);
            equestTab.Size = new Size(939, 535);
            equestTab.TabIndex = 0;
            equestTab.Text = "Requests";
            equestTab.UseVisualStyleBackColor = true;
            // 
            // requestList
            // 
            requestList.FormattingEnabled = true;
            requestList.Location = new Point(6, 6);
            requestList.Name = "requestList";
            requestList.Size = new Size(325, 524);
            requestList.TabIndex = 0;
            // 
            // typeTab
            // 
            typeTab.Controls.Add(tyoeList);
            typeTab.Location = new Point(4, 29);
            typeTab.Name = "typeTab";
            typeTab.Padding = new Padding(3);
            typeTab.Size = new Size(939, 535);
            typeTab.TabIndex = 1;
            typeTab.Text = "Types";
            typeTab.UseVisualStyleBackColor = true;
            // 
            // serverTab
            // 
            serverTab.Location = new Point(4, 29);
            serverTab.Name = "serverTab";
            serverTab.Size = new Size(939, 535);
            serverTab.TabIndex = 2;
            serverTab.Text = "Server";
            serverTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 8);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "Path";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(533, 27);
            textBox1.TabIndex = 2;
            // 
            // tyoeList
            // 
            tyoeList.FormattingEnabled = true;
            tyoeList.Location = new Point(6, 6);
            tyoeList.Name = "tyoeList";
            tyoeList.Size = new Size(277, 524);
            tyoeList.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 582);
            Controls.Add(tab);
            Icon = (Icon)resources.GetObject("$this.Icon");
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