using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CacheUtility.Cache;
using ComponentPro.Compression;
using ComponentPro.IO;

namespace CacheUtility
{
    public partial class frmZipper : Form
    {
        public frmZipper()
        {
            InitializeComponent();
            fileResults.Clear();
        }

        public string recentCacheDirectory { get; set; }
        private readonly List<string> fileResults = new List<string>();

        public void ClearLists()   
        {
            folderResults.Items.Clear();
            fileResults.Clear();
            zipCacheContents.Visible = false;
        }

        private void LoadCacheButton_Click(object sender, EventArgs e)
        {
            ClearLists();

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select your cache directory";

                if (!string.IsNullOrEmpty(recentCacheDirectory))
                    folderBrowser.SelectedPath = recentCacheDirectory;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    recentCacheDirectory = folderBrowser.SelectedPath;
                    var filesFound = Directory.GetFiles(folderBrowser.SelectedPath);

                    foreach (var folderFiles in filesFound)
                    {
                        folderResults.Items.Add(folderFiles.Replace(folderBrowser.SelectedPath+ "\\", string.Empty));
                        fileResults.Add(folderFiles);
                        zipCacheContents.Visible = true;
                    }
                }
            }
        }

        private void zipCacheContents_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(recentCacheDirectory))
            {
                DialogResult dr = MessageBox.Show("Would you like to zip this folder's contents?", string.Empty, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    ZipContents(recentCacheDirectory, new DirectoryInfo(recentCacheDirectory).Name);
            }
        }

        public void ZipContents(string directory, string folderName)
        {
            Zip zip = new Zip();
            zip.Create(Path.Combine(directory, folderName + ".zip"));
            zip.Progress += ZipProgress;
            zip.AddDirectory(directory, true);
            zip.DeleteFile(Path.Combine(folderName, folderName + ".zip"));
            zip.Close();
            zipCacheContents.Visible = false;
            ProgressBar.Value = 0;
            DialogResult dr = MessageBox.Show("Would you like to view your files?", string.Empty, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                OpenFolder(directory);
        }

        private void ZipProgress(object sender, FileSystemProgressEventArgs e)
        {
            Console.WriteLine("Total: %{0} completed", e.TotalPercentage);
            ProgressBar.Value = Convert.ToInt32(e.TotalPercentage);
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
