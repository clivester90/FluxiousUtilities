using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacheUtility.Cache;
using CacheUtility.ZipUtilities;
using ComponentPro.IO;

namespace CacheUtility
{
    public partial class frmZipper : Form
    {

        public frmZipper()
        {
            InitializeComponent();
            StatusText.Text = string.Empty;
            ProgressBar.Visible = false;
            fileResults.Clear();
            zip.ProgressUpdated += DisplayProgress;
        }

        public string RecentFolder { get; set; }
        private readonly List<string> fileResults = new List<string>();
        private readonly ZipHandler zip = new ZipHandler();

        public void ClearLists()
        {
            folderResults.Items.Clear();
            fileResults.Clear();
            zipCacheContents.Visible = false;
        }

        private void LoadCacheButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select your cache directory";

                if (!string.IsNullOrEmpty(RecentFolder))
                    folderBrowser.SelectedPath = RecentFolder;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    ClearLists();
                    RecentFolder = folderBrowser.SelectedPath;
                    var filesFound = Directory.GetFiles(folderBrowser.SelectedPath);

                    foreach (var folderFiles in filesFound)
                    {
                        folderResults.Items.Add(folderFiles.Replace(folderBrowser.SelectedPath + "\\", string.Empty));
                        fileResults.Add(folderFiles);
                    }
                    zipCacheContents.Visible = true;
                }
            }
        }

        private void ZipCacheContents_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecentFolder))
                return;

            DialogResult dr = MessageBox.Show("Would you like to zip this folder's contents?", string.Empty, MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;
            ProgressBar.Visible = true;
            zip.CreateZip(RecentFolder, new DirectoryInfo(RecentFolder).Name);
            HideProgressBar();
            SetStatusText("Finished Zipping contents.");
            dr = MessageBox.Show("Would you like to view your files?", string.Empty, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                OpenFolder(RecentFolder);
        }

        private void FolderResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileViewData.Rows.Clear();
            var fileName = folderResults.SelectedItem.ToString();
            var filePath = Path.Combine(RecentFolder, fileName);
            var fileType = Path.GetExtension(filePath);

            CacheConstants constants = new CacheConstants();
            var fileSize = constants.GetFileSize(new FileInfo(filePath).Length);

            fileViewData.Rows.Add(fileName, fileType, fileSize);
        }


        private void DisplayProgress(object sender, FileSystemProgressEventArgs e)
        {
            Console.WriteLine("Total: %{0} completed", e.TotalPercentage);
            ProgressBar.Value = Convert.ToInt32(e.TotalPercentage);
            StatusText.Text = "Zipping folder contents...";
            StatusText.Refresh();
        }

        private void HideProgressBar()
        {
            zipCacheContents.Visible = false;
            ProgressBar.Value = 0;
            ProgressBar.Visible = false;
        }

        private void SetStatusText(string message, int milliseconds = 2000)
        {
            StatusText.Text = message;
            Task.Delay(milliseconds).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { StatusText.Visible = false; }));
            });
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
        }


    }

}
