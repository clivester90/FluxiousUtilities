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
            this.StatusText = new System.Windows.Forms.Label();
            this.zipCacheContents = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(13, 301);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(199, 28);
            this.ProgressBar.TabIndex = 0;
            // 
            // LoadCacheButton
            // 
            this.LoadCacheButton.Location = new System.Drawing.Point(317, 301);
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
            this.folderResults.Size = new System.Drawing.Size(200, 251);
            this.folderResults.TabIndex = 2;
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(175, 276);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 13);
            this.StatusText.TabIndex = 3;
            // 
            // zipCacheContents
            // 
            this.zipCacheContents.Location = new System.Drawing.Point(224, 301);
            this.zipCacheContents.Name = "zipCacheContents";
            this.zipCacheContents.Size = new System.Drawing.Size(83, 28);
            this.zipCacheContents.TabIndex = 4;
            this.zipCacheContents.Text = "Zip";
            this.zipCacheContents.UseVisualStyleBackColor = true;
            this.zipCacheContents.Visible = false;
            this.zipCacheContents.Click += new System.EventHandler(this.zipCacheContents_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(212, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 251);
            this.listBox1.TabIndex = 5;
            // 
            // frmZipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 333);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.zipCacheContents);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.folderResults);
            this.Controls.Add(this.LoadCacheButton);
            this.Controls.Add(this.ProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clive\'s Zipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button LoadCacheButton;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Button zipCacheContents;
        public System.Windows.Forms.ListBox folderResults;
        public System.Windows.Forms.ListBox listBox1;
    }
}

