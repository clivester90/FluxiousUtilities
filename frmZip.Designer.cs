namespace CacheUtility
{
    partial class frmZipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZipper));
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LoadCacheButton = new System.Windows.Forms.Button();
            this.folderResults = new System.Windows.Forms.ListBox();
            this.zipCacheContents = new System.Windows.Forms.Button();
            this.fileViewData = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusText = new System.Windows.Forms.Label();
            this.FilesLoaded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(164, 314);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(199, 10);
            this.ProgressBar.TabIndex = 0;
            // 
            // LoadCacheButton
            // 
            this.LoadCacheButton.Location = new System.Drawing.Point(472, 301);
            this.LoadCacheButton.Name = "LoadCacheButton";
            this.LoadCacheButton.Size = new System.Drawing.Size(83, 28);
            this.LoadCacheButton.TabIndex = 1;
            this.LoadCacheButton.Text = "Load Cache";
            this.LoadCacheButton.UseVisualStyleBackColor = true;
            this.LoadCacheButton.Click += new System.EventHandler(this.LoadCacheButton_Click);
            // 
            // folderResults
            // 
            this.folderResults.FormattingEnabled = true;
            this.folderResults.Location = new System.Drawing.Point(1, 1);
            this.folderResults.Name = "folderResults";
            this.folderResults.Size = new System.Drawing.Size(150, 251);
            this.folderResults.TabIndex = 2;
            this.folderResults.SelectedIndexChanged += new System.EventHandler(this.FolderResults_SelectedIndexChanged);
            // 
            // zipCacheContents
            // 
            this.zipCacheContents.Location = new System.Drawing.Point(383, 301);
            this.zipCacheContents.Name = "zipCacheContents";
            this.zipCacheContents.Size = new System.Drawing.Size(83, 28);
            this.zipCacheContents.TabIndex = 4;
            this.zipCacheContents.Text = "Zip";
            this.zipCacheContents.UseVisualStyleBackColor = true;
            this.zipCacheContents.Visible = false;
            this.zipCacheContents.Click += new System.EventHandler(this.ZipCacheContents_Click);
            // 
            // fileViewData
            // 
            this.fileViewData.AllowUserToAddRows = false;
            this.fileViewData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.fileViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileType,
            this.FileSize});
            this.fileViewData.Location = new System.Drawing.Point(150, 1);
            this.fileViewData.Name = "fileViewData";
            this.fileViewData.Size = new System.Drawing.Size(418, 251);
            this.fileViewData.TabIndex = 5;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.Width = 140;
            // 
            // FileType
            // 
            this.FileType.HeaderText = "File Type";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            this.FileType.Width = 120;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "File Size";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.Width = 133;
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(12, 314);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(61, 13);
            this.StatusText.TabIndex = 6;
            this.StatusText.Text = "Status Text";
            // 
            // FilesLoaded
            // 
            this.FilesLoaded.AutoSize = true;
            this.FilesLoaded.Location = new System.Drawing.Point(1, 259);
            this.FilesLoaded.Name = "FilesLoaded";
            this.FilesLoaded.Size = new System.Drawing.Size(70, 13);
            this.FilesLoaded.TabIndex = 7;
            this.FilesLoaded.Text = "Files Loaded:";
            // 
            // frmZipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 329);
            this.Controls.Add(this.FilesLoaded);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.fileViewData);
            this.Controls.Add(this.zipCacheContents);
            this.Controls.Add(this.folderResults);
            this.Controls.Add(this.LoadCacheButton);
            this.Controls.Add(this.ProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clive\'s Zipper";
            ((System.ComponentModel.ISupportInitialize)(this.fileViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button LoadCacheButton;
        private System.Windows.Forms.Button zipCacheContents;
        public System.Windows.Forms.ListBox folderResults;
        private System.Windows.Forms.DataGridView fileViewData;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.Label FilesLoaded;
    }
}

