namespace CacheUtility
{
    partial class FrmZipper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZipper));
            this.LoadCacheButton = new System.Windows.Forms.Button();
            this.folderResults = new System.Windows.Forms.ListBox();
            this.zipCacheContents = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.Label();
            this.FilesLoaded = new System.Windows.Forms.Label();
            this.zipBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.fileSelectedName = new System.Windows.Forms.Label();
            this.fileSelectedType = new System.Windows.Forms.Label();
            this.fileSelectedSize = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DirectoryFinderWorker = new System.ComponentModel.BackgroundWorker();
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.DirectoryTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFileTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ZipFolderTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearPageTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFileSelectedTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchResultsText = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.MinimizeButton = new System.Windows.Forms.ToolStripButton();
            this.CIcon = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadCacheButton
            // 
            this.LoadCacheButton.BackColor = System.Drawing.Color.LightGray;
            this.LoadCacheButton.FlatAppearance.BorderSize = 4;
            this.LoadCacheButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadCacheButton.Image")));
            this.LoadCacheButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadCacheButton.Location = new System.Drawing.Point(12, 43);
            this.LoadCacheButton.Name = "LoadCacheButton";
            this.LoadCacheButton.Size = new System.Drawing.Size(89, 28);
            this.LoadCacheButton.TabIndex = 1;
            this.LoadCacheButton.Text = "Directory";
            this.LoadCacheButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadCacheButton.UseVisualStyleBackColor = false;
            this.LoadCacheButton.Click += new System.EventHandler(this.LoadDirectoryButton_Click);
            // 
            // folderResults
            // 
            this.folderResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.folderResults.FormattingEnabled = true;
            this.folderResults.HorizontalScrollbar = true;
            this.folderResults.Location = new System.Drawing.Point(12, 83);
            this.folderResults.Name = "folderResults";
            this.folderResults.Size = new System.Drawing.Size(232, 394);
            this.folderResults.Sorted = true;
            this.folderResults.TabIndex = 2;
            this.folderResults.SelectedIndexChanged += new System.EventHandler(this.FolderResults_SelectedIndexChanged);
            // 
            // zipCacheContents
            // 
            this.zipCacheContents.BackColor = System.Drawing.Color.LightGray;
            this.zipCacheContents.Enabled = false;
            this.zipCacheContents.Image = ((System.Drawing.Image)(resources.GetObject("zipCacheContents.Image")));
            this.zipCacheContents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zipCacheContents.Location = new System.Drawing.Point(202, 43);
            this.zipCacheContents.Name = "zipCacheContents";
            this.zipCacheContents.Size = new System.Drawing.Size(89, 28);
            this.zipCacheContents.TabIndex = 4;
            this.zipCacheContents.Text = "Zip Folder";
            this.zipCacheContents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zipCacheContents.UseVisualStyleBackColor = false;
            this.zipCacheContents.Click += new System.EventHandler(this.ZipCacheContents_Click);
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(218, 482);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 13);
            this.StatusText.TabIndex = 6;
            // 
            // FilesLoaded
            // 
            this.FilesLoaded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilesLoaded.AutoSize = true;
            this.FilesLoaded.BackColor = System.Drawing.Color.Transparent;
            this.FilesLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesLoaded.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FilesLoaded.Location = new System.Drawing.Point(670, 49);
            this.FilesLoaded.Name = "FilesLoaded";
            this.FilesLoaded.Size = new System.Drawing.Size(90, 16);
            this.FilesLoaded.TabIndex = 7;
            this.FilesLoaded.Text = "Files Loaded:";
            // 
            // zipBackgroundWorker
            // 
            this.zipBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ZipBackgroundWorker_DoWork);
            this.zipBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ZipBackgroundWorker_OnCompetion);
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.LightGray;
            this.loadFileButton.Enabled = false;
            this.loadFileButton.Image = ((System.Drawing.Image)(resources.GetObject("loadFileButton.Image")));
            this.loadFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadFileButton.Location = new System.Drawing.Point(107, 43);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(89, 28);
            this.loadFileButton.TabIndex = 8;
            this.loadFileButton.Text = "Open File";
            this.loadFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // fileSelectedName
            // 
            this.fileSelectedName.AutoSize = true;
            this.fileSelectedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.fileSelectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectedName.Location = new System.Drawing.Point(337, 136);
            this.fileSelectedName.Name = "fileSelectedName";
            this.fileSelectedName.Size = new System.Drawing.Size(59, 16);
            this.fileSelectedName.TabIndex = 9;
            this.fileSelectedName.Text = "File: N/A";
            // 
            // fileSelectedType
            // 
            this.fileSelectedType.AutoSize = true;
            this.fileSelectedType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.fileSelectedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectedType.Location = new System.Drawing.Point(337, 182);
            this.fileSelectedType.Name = "fileSelectedType";
            this.fileSelectedType.Size = new System.Drawing.Size(94, 16);
            this.fileSelectedType.TabIndex = 10;
            this.fileSelectedType.Text = "File Type: N/A";
            // 
            // fileSelectedSize
            // 
            this.fileSelectedSize.AutoSize = true;
            this.fileSelectedSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.fileSelectedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectedSize.Location = new System.Drawing.Point(626, 182);
            this.fileSelectedSize.Name = "fileSelectedSize";
            this.fileSelectedSize.Size = new System.Drawing.Size(91, 16);
            this.fileSelectedSize.TabIndex = 12;
            this.fileSelectedSize.Text = "File Size:  N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 142);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // DirectoryFinderWorker
            // 
            this.DirectoryFinderWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DirectoryFinderWorker_DoWork);
            this.DirectoryFinderWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DirectoryFinderWorker_OnCompetion);
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.BackColor = System.Drawing.Color.LightGray;
            this.ClearScreenButton.Enabled = false;
            this.ClearScreenButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearScreenButton.Image")));
            this.ClearScreenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearScreenButton.Location = new System.Drawing.Point(297, 43);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(89, 28);
            this.ClearScreenButton.TabIndex = 15;
            this.ClearScreenButton.Text = "Clear Page";
            this.ClearScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearScreenButton.UseVisualStyleBackColor = false;
            this.ClearScreenButton.Click += new System.EventHandler(this.ClearScreenButton_Click);
            // 
            // DirectoryTooltip
            // 
            this.DirectoryTooltip.AutoPopDelay = 5000;
            this.DirectoryTooltip.InitialDelay = 0;
            this.DirectoryTooltip.ReshowDelay = 100;
            this.DirectoryTooltip.Tag = "Load Directory";
            // 
            // OpenFileTooltip
            // 
            this.OpenFileTooltip.AutoPopDelay = 5000;
            this.OpenFileTooltip.InitialDelay = 0;
            this.OpenFileTooltip.ReshowDelay = 100;
            this.OpenFileTooltip.Tag = "Open File";
            // 
            // ZipFolderTooltip
            // 
            this.ZipFolderTooltip.AutoPopDelay = 5000;
            this.ZipFolderTooltip.InitialDelay = 0;
            this.ZipFolderTooltip.ReshowDelay = 100;
            this.ZipFolderTooltip.Tag = "Zip Current Directory";
            // 
            // ClearPageTooltip
            // 
            this.ClearPageTooltip.AutoPopDelay = 5000;
            this.ClearPageTooltip.InitialDelay = 0;
            this.ClearPageTooltip.ReshowDelay = 100;
            this.ClearPageTooltip.Tag = "Clear Page Data";
            // 
            // OpenFileSelectedTooltip
            // 
            this.OpenFileSelectedTooltip.AutoPopDelay = 5000;
            this.OpenFileSelectedTooltip.InitialDelay = 0;
            this.OpenFileSelectedTooltip.ReshowDelay = 100;
            this.OpenFileSelectedTooltip.Tag = "Open Selected File";
            // 
            // SearchResultsText
            // 
            this.SearchResultsText.Location = new System.Drawing.Point(12, 479);
            this.SearchResultsText.Name = "SearchResultsText";
            this.SearchResultsText.Size = new System.Drawing.Size(232, 20);
            this.SearchResultsText.TabIndex = 16;
            this.SearchResultsText.Text = "Search...";
            this.SearchResultsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchResultsText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchResultsText_MouseClick);
            this.SearchResultsText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchResultsText_KeyEvent);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseButton,
            this.MinimizeButton,
            this.CIcon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 31);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CloseButton
            // 
            this.CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "Close Button";
            this.CloseButton.ToolTipText = "Close Application";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MinimizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(28, 28);
            this.MinimizeButton.Text = "Minimize Button";
            this.MinimizeButton.ToolTipText = "Minimize";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CIcon
            // 
            this.CIcon.AutoToolTip = false;
            this.CIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CIcon.Image = ((System.Drawing.Image)(resources.GetObject("CIcon.Image")));
            this.CIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CIcon.Name = "CIcon";
            this.CIcon.Size = new System.Drawing.Size(28, 28);
            this.CIcon.Text = "C# Icon";
            // 
            // FrmZipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(894, 506);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SearchResultsText);
            this.Controls.Add(this.ClearScreenButton);
            this.Controls.Add(this.fileSelectedName);
            this.Controls.Add(this.fileSelectedType);
            this.Controls.Add(this.fileSelectedSize);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.FilesLoaded);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.zipCacheContents);
            this.Controls.Add(this.folderResults);
            this.Controls.Add(this.LoadCacheButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmZipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSPS Tool Operator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadCacheButton;
        private System.Windows.Forms.Button zipCacheContents;
        public System.Windows.Forms.ListBox folderResults;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label FilesLoaded;
        public System.ComponentModel.BackgroundWorker zipBackgroundWorker;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Label fileSelectedName;
        private System.Windows.Forms.Label fileSelectedType;
        private System.Windows.Forms.Label fileSelectedSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.ComponentModel.BackgroundWorker DirectoryFinderWorker;
        private System.Windows.Forms.Button ClearScreenButton;
        private System.Windows.Forms.ToolTip DirectoryTooltip;
        private System.Windows.Forms.ToolTip OpenFileTooltip;
        private System.Windows.Forms.ToolTip ZipFolderTooltip;
        private System.Windows.Forms.ToolTip ClearPageTooltip;
        private System.Windows.Forms.ToolTip OpenFileSelectedTooltip;
        private System.Windows.Forms.TextBox SearchResultsText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ToolStripButton MinimizeButton;
        private System.Windows.Forms.ToolStripButton CIcon;
    }
}

