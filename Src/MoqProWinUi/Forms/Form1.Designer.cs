namespace GettingStarted1
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            olvSongs = new BrightIdeasSoftware.ObjectListView();
            titleColumn = new BrightIdeasSoftware.OLVColumn();
            sizeColumn = new BrightIdeasSoftware.OLVColumn();
            lastPlayedColumn = new BrightIdeasSoftware.OLVColumn();
            ratingColumn = new BrightIdeasSoftware.OLVColumn();
            ((System.ComponentModel.ISupportInitialize)olvSongs).BeginInit();
            SuspendLayout();
            // 
            // olvSongs
            // 
            olvSongs.AllColumns.Add(titleColumn);
            olvSongs.AllColumns.Add(sizeColumn);
            olvSongs.AllColumns.Add(lastPlayedColumn);
            olvSongs.AllColumns.Add(ratingColumn);
            olvSongs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            olvSongs.CellEditUseWholeCell = false;
            olvSongs.Columns.AddRange(new ColumnHeader[] { titleColumn, sizeColumn, lastPlayedColumn, ratingColumn });
            olvSongs.Location = new Point(14, 30);
            olvSongs.Margin = new Padding(4, 3, 4, 3);
            olvSongs.Name = "olvSongs";
            olvSongs.ShowGroups = false;
            olvSongs.Size = new Size(658, 306);
            olvSongs.TabIndex = 0;
            olvSongs.UseCompatibleStateImageBehavior = false;
            olvSongs.View = View.Details;
            // 
            // titleColumn
            // 
            titleColumn.AspectName = "Title";
            titleColumn.Text = "Title";
            titleColumn.Width = 160;
            // 
            // sizeColumn
            // 
            sizeColumn.AspectName = "GetSizeInMb";
            sizeColumn.AspectToStringFormat = "{0:#,##0.0}";
            sizeColumn.Text = "Size (MB)";
            sizeColumn.TextAlign = HorizontalAlignment.Center;
            sizeColumn.Width = 94;
            // 
            // lastPlayedColumn
            // 
            lastPlayedColumn.AspectName = "LastPlayed";
            lastPlayedColumn.AspectToStringFormat = "{0:d}";
            lastPlayedColumn.Text = "Last Played";
            lastPlayedColumn.Width = 150;
            // 
            // ratingColumn
            // 
            ratingColumn.AspectName = "Rating";
            ratingColumn.Text = "Rating";
            ratingColumn.TextAlign = HorizontalAlignment.Center;
            ratingColumn.Width = 85;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 351);
            Controls.Add(olvSongs);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ObjectListView Getting Started 1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)olvSongs).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvSongs;
        private BrightIdeasSoftware.OLVColumn titleColumn;
        private BrightIdeasSoftware.OLVColumn sizeColumn;
        private BrightIdeasSoftware.OLVColumn lastPlayedColumn;
        private BrightIdeasSoftware.OLVColumn ratingColumn;
    }
}

