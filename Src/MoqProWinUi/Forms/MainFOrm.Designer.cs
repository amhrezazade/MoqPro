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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tab = new TabControl();
            equestTab = new TabPage();
            requestListPanel = new Panel();
            lstRequests = new ListBox();
            panel3 = new Panel();
            btnRemoveRequest = new Button();
            btnUpdateRequest = new Button();
            btnAddRequest = new Button();
            typeTab = new TabPage();
            typeMainPanel = new Panel();
            lstTypes = new ListBox();
            typePanel = new Panel();
            btnRemoveType = new Button();
            btnUpdateType = new Button();
            btnAddType = new Button();
            serverTab = new TabPage();
            serverMainPanel = new Panel();
            txtLog = new TextBox();
            panel2 = new Panel();
            lblServerState = new Label();
            btnServer = new Button();
            timer = new System.Windows.Forms.Timer(components);
            tab.SuspendLayout();
            equestTab.SuspendLayout();
            requestListPanel.SuspendLayout();
            panel3.SuspendLayout();
            typeTab.SuspendLayout();
            typeMainPanel.SuspendLayout();
            typePanel.SuspendLayout();
            serverTab.SuspendLayout();
            serverMainPanel.SuspendLayout();
            panel2.SuspendLayout();
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
            tab.Size = new Size(533, 318);
            tab.TabIndex = 0;
            // 
            // equestTab
            // 
            equestTab.Controls.Add(requestListPanel);
            equestTab.Controls.Add(panel3);
            equestTab.Location = new Point(4, 29);
            equestTab.Name = "equestTab";
            equestTab.Padding = new Padding(3);
            equestTab.Size = new Size(525, 285);
            equestTab.TabIndex = 0;
            equestTab.Text = "Requests";
            equestTab.UseVisualStyleBackColor = true;
            // 
            // requestListPanel
            // 
            requestListPanel.Controls.Add(lstRequests);
            requestListPanel.Dock = DockStyle.Fill;
            requestListPanel.Location = new Point(3, 43);
            requestListPanel.Name = "requestListPanel";
            requestListPanel.Size = new Size(519, 239);
            requestListPanel.TabIndex = 2;
            // 
            // lstRequests
            // 
            lstRequests.Font = new Font("Segoe UI", 11F);
            lstRequests.FormattingEnabled = true;
            lstRequests.ItemHeight = 25;
            lstRequests.Location = new Point(39, 17);
            lstRequests.Name = "lstRequests";
            lstRequests.Size = new Size(150, 104);
            lstRequests.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRemoveRequest);
            panel3.Controls.Add(btnUpdateRequest);
            panel3.Controls.Add(btnAddRequest);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(519, 40);
            panel3.TabIndex = 1;
            // 
            // btnRemoveRequest
            // 
            btnRemoveRequest.Location = new Point(212, 3);
            btnRemoveRequest.Name = "btnRemoveRequest";
            btnRemoveRequest.Size = new Size(94, 29);
            btnRemoveRequest.TabIndex = 2;
            btnRemoveRequest.Text = "Remove";
            btnRemoveRequest.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRequest
            // 
            btnUpdateRequest.Location = new Point(112, 3);
            btnUpdateRequest.Name = "btnUpdateRequest";
            btnUpdateRequest.Size = new Size(94, 29);
            btnUpdateRequest.TabIndex = 1;
            btnUpdateRequest.Text = "Update";
            btnUpdateRequest.UseVisualStyleBackColor = true;
            // 
            // btnAddRequest
            // 
            btnAddRequest.Location = new Point(12, 3);
            btnAddRequest.Name = "btnAddRequest";
            btnAddRequest.Size = new Size(94, 29);
            btnAddRequest.TabIndex = 0;
            btnAddRequest.Text = "Add";
            btnAddRequest.UseVisualStyleBackColor = true;
            // 
            // typeTab
            // 
            typeTab.Controls.Add(typeMainPanel);
            typeTab.Controls.Add(typePanel);
            typeTab.Location = new Point(4, 29);
            typeTab.Name = "typeTab";
            typeTab.Padding = new Padding(3);
            typeTab.Size = new Size(525, 285);
            typeTab.TabIndex = 1;
            typeTab.Text = "Types";
            typeTab.UseVisualStyleBackColor = true;
            // 
            // typeMainPanel
            // 
            typeMainPanel.Controls.Add(lstTypes);
            typeMainPanel.Dock = DockStyle.Fill;
            typeMainPanel.Location = new Point(3, 37);
            typeMainPanel.Name = "typeMainPanel";
            typeMainPanel.Size = new Size(519, 245);
            typeMainPanel.TabIndex = 1;
            // 
            // lstTypes
            // 
            lstTypes.Font = new Font("Segoe UI", 11F);
            lstTypes.FormattingEnabled = true;
            lstTypes.ItemHeight = 25;
            lstTypes.Location = new Point(35, 22);
            lstTypes.Name = "lstTypes";
            lstTypes.Size = new Size(150, 104);
            lstTypes.TabIndex = 0;
            // 
            // typePanel
            // 
            typePanel.Controls.Add(btnRemoveType);
            typePanel.Controls.Add(btnUpdateType);
            typePanel.Controls.Add(btnAddType);
            typePanel.Dock = DockStyle.Top;
            typePanel.Location = new Point(3, 3);
            typePanel.Name = "typePanel";
            typePanel.Size = new Size(519, 34);
            typePanel.TabIndex = 0;
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
            // btnUpdateType
            // 
            btnUpdateType.Location = new Point(112, 3);
            btnUpdateType.Name = "btnUpdateType";
            btnUpdateType.Size = new Size(94, 29);
            btnUpdateType.TabIndex = 1;
            btnUpdateType.Text = "Update";
            btnUpdateType.UseVisualStyleBackColor = true;
            btnUpdateType.Click += btnUpdateType_Click;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(12, 3);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(94, 29);
            btnAddType.TabIndex = 0;
            btnAddType.Text = "Add";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // serverTab
            // 
            serverTab.Controls.Add(serverMainPanel);
            serverTab.Controls.Add(panel2);
            serverTab.Location = new Point(4, 29);
            serverTab.Name = "serverTab";
            serverTab.Size = new Size(525, 285);
            serverTab.TabIndex = 2;
            serverTab.Text = "Server";
            serverTab.UseVisualStyleBackColor = true;
            // 
            // serverMainPanel
            // 
            serverMainPanel.Controls.Add(txtLog);
            serverMainPanel.Dock = DockStyle.Fill;
            serverMainPanel.Location = new Point(0, 42);
            serverMainPanel.Name = "serverMainPanel";
            serverMainPanel.Size = new Size(525, 243);
            serverMainPanel.TabIndex = 3;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(32, 17);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(250, 160);
            txtLog.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblServerState);
            panel2.Controls.Add(btnServer);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 42);
            panel2.TabIndex = 2;
            // 
            // lblServerState
            // 
            lblServerState.AutoSize = true;
            lblServerState.ForeColor = Color.Red;
            lblServerState.Location = new Point(130, 13);
            lblServerState.Name = "lblServerState";
            lblServerState.Size = new Size(66, 20);
            lblServerState.TabIndex = 1;
            lblServerState.Text = "Stopped";
            // 
            // btnServer
            // 
            btnServer.Location = new Point(13, 8);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(111, 31);
            btnServer.TabIndex = 0;
            btnServer.Tag = "";
            btnServer.Text = "Start Server";
            btnServer.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 373);
            Controls.Add(tab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            tab.ResumeLayout(false);
            equestTab.ResumeLayout(false);
            requestListPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            typeTab.ResumeLayout(false);
            typeMainPanel.ResumeLayout(false);
            typePanel.ResumeLayout(false);
            serverTab.ResumeLayout(false);
            serverMainPanel.ResumeLayout(false);
            serverMainPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Label lblServerState;
        private Button btnServer;
        private Panel serverMainPanel;
        private TextBox txtLog;
        private Panel requestListPanel;
        private Panel panel3;
        private Button btnRemoveRequest;
        private Button btnUpdateRequest;
        private Button btnAddRequest;
        private ListBox lstRequests;
        private ListBox lstTypes;
        private System.Windows.Forms.Timer timer;
    }
}