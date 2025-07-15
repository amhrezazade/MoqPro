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
            typeTab = new TabPage();
            typeMainPanel = new Panel();
            typePanel = new Panel();
            serverTab = new TabPage();
            btnAddType = new Button();
            btnUpdateType = new Button();
            btnRemoveType = new Button();
            tab.SuspendLayout();
            typeTab.SuspendLayout();
            typePanel.SuspendLayout();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(equestTab);
            tab.Controls.Add(typeTab);
            tab.Controls.Add(serverTab);
            tab.Location = new Point(11, 12);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(947, 568);
            tab.TabIndex = 0;
            // 
            // equestTab
            // 
            equestTab.Location = new Point(4, 29);
            equestTab.Name = "equestTab";
            equestTab.Padding = new Padding(3);
            equestTab.Size = new Size(939, 535);
            equestTab.TabIndex = 0;
            equestTab.Text = "Requests";
            equestTab.UseVisualStyleBackColor = true;
            // 
            // typeTab
            // 
            typeTab.Controls.Add(typeMainPanel);
            typeTab.Controls.Add(typePanel);
            typeTab.Location = new Point(4, 29);
            typeTab.Name = "typeTab";
            typeTab.Padding = new Padding(3);
            typeTab.Size = new Size(939, 535);
            typeTab.TabIndex = 1;
            typeTab.Text = "Types";
            typeTab.UseVisualStyleBackColor = true;
            // 
            // typeMainPanel
            // 
            typeMainPanel.Dock = DockStyle.Fill;
            typeMainPanel.Location = new Point(3, 37);
            typeMainPanel.Name = "typeMainPanel";
            typeMainPanel.Size = new Size(933, 495);
            typeMainPanel.TabIndex = 1;
            // 
            // typePanel
            // 
            typePanel.Controls.Add(btnRemoveType);
            typePanel.Controls.Add(btnUpdateType);
            typePanel.Controls.Add(btnAddType);
            typePanel.Dock = DockStyle.Top;
            typePanel.Location = new Point(3, 3);
            typePanel.Name = "typePanel";
            typePanel.Size = new Size(933, 34);
            typePanel.TabIndex = 0;
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
            // btnAddType
            // 
            btnAddType.Location = new Point(12, 3);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(94, 29);
            btnAddType.TabIndex = 0;
            btnAddType.Text = "Add";
            btnAddType.UseVisualStyleBackColor = true;
            // 
            // btnUpdateType
            // 
            btnUpdateType.Location = new Point(112, 3);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(94, 29);
            btnUpdateType.TabIndex = 1;
            btnUpdateType.Text = "Update";
            btnUpdateType.UseVisualStyleBackColor = true;
            // 
            // btnRemoveType
            // 
            btnRemoveType.Location = new Point(212, 3);
            btnRemoveType.Name = "btnRemoveType";
            btnRemoveType.Size = new Size(94, 29);
            btnRemoveType.TabIndex = 2;
            btnRemoveType.Text = "Remove";
            btnRemoveType.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 581);
            Controls.Add(tab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tab.ResumeLayout(false);
            typeTab.ResumeLayout(false);
            typePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage equestTab;
        private TabPage typeTab;
        private TabPage serverTab;
        private Panel typePanel;
        private Panel typeMainPanel;
        private Button btnRemoveType;
        private Button btnUpdateType;
        private Button btnAddType;
    }
}