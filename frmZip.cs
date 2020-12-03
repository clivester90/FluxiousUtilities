using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
    public partial class FrmZipper : Form
    {

        public FrmZipper()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            fileResults.Clear();
            DirectoryTooltip.SetToolTip(LoadCacheButton, "Load Directory");
            ZipFolderTooltip.SetToolTip(zipCacheContents, "Zip Selected Directory");
            ClearPageTooltip.SetToolTip(ClearScreenButton, "Clear Page Data");
        }

        public string RecentFolder { get; set; }
        private readonly List<string> fileResults = new List<string>();
        private readonly DirectoryHandler directory = new DirectoryHandler();

        public void ClearLists()
        {
            folderResults.Items.Clear();
            fileResults.Clear();
            FilesLoaded.Text = string.Empty;
        }

        private void LoadDirectoryButton_Click(object sender, EventArgs e)
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

                    DirectoryFinderWorker.RunWorkerAsync();
                }
            }
        }

        private void DirectoryFinderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            directory.LocateFilesInDirectory(RecentFolder);
        }

        private void DirectoryFinderWorker_OnCompetion(object sender, RunWorkerCompletedEventArgs e)
        {
            directory.filesFound.ToList().ForEach(fileFound =>
            {
                folderResults.Items.Add(fileFound.Replace(RecentFolder + "\\", string.Empty));
                fileResults.Add(fileFound);
            });

            int count = folderResults.Items.Count;
            FilesLoaded.Text = count > 0 ? $"Files Loaded: {folderResults.Items.Count}" : "No openable files found.";

            zipCacheContents.Enabled = true;
            ClearScreenButton.Enabled = true;
        }

        private void ZipCacheContents_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecentFolder))
                return;

            DialogResult dr = MessageBox.Show("Would you like to zip this folder's contents? \nThis may take a while depending on directory size.", string.Empty, MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            Cursor.Current = Cursors.WaitCursor;
            zipBackgroundWorker.RunWorkerAsync();
        }

        private void ZipBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            directory.CreateZipFile(RecentFolder, new DirectoryInfo(RecentFolder).Name);
        }

        private void ZipBackgroundWorker_OnCompetion(object sender, RunWorkerCompletedEventArgs e)
        {
            SetStatusText("Finished zipping contents.", 3000);
            Cursor.Current = Cursors.Default;
            DialogResult dr = MessageBox.Show("Would you like to view your files?", string.Empty, MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
                OpenFolder(RecentFolder);
        }

        private void FolderResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileName = folderResults.SelectedItem.ToString();
            var filePath = Path.Combine(RecentFolder, fileName);
            var fileType = Path.GetExtension(filePath);

            CacheConstants constants = new CacheConstants();
            var fileSize = constants.GetFileSize(new FileInfo(filePath).Length);

            fileSelectedName.Text = "File: " + fileName;
            fileSelectedType.Text = "File Type: " + fileType;
            fileSelectedSize.Text = "File Size: " + fileSize;

            loadFileButton.Enabled = fileName.EndsWith(".jar");

            OpenFileTooltip.SetToolTip(loadFileButton, "Open " + filePath);

            fileToOpen = filePath;

        }

        public string fileToOpen;

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            Process.Start(fileToOpen);
        }

        private void SetStatusText(string message, int milliseconds = 2000)
        {
            StatusText.Text = message;
            Task.Delay(milliseconds).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    StatusText.Text = string.Empty;
                }));
            });
        }

        private void OpenFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                return;
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = folderPath,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }

        private void ClearScreenButton_Click(object sender, EventArgs e)
        {
            ClearLists();
            fileSelectedName.Text = "File:";
            fileSelectedType.Text = "File Type:";
            fileSelectedSize.Text = "File Size:";
        }

        private List<string> filteredResults = new List<string>();

        private void SearchResultsText_KeyEvent(object sender, KeyEventArgs e)
        {
            folderResults.BeginUpdate();

            filteredResults = fileResults.Where(x => x.ToLower().Contains(SearchResultsText.Text.ToLower())).ToList();
            folderResults.Items.Clear();
            filteredResults.ToList().ForEach(fileFound => {
                folderResults.Items.Add(fileFound.Replace(RecentFolder + "\\", string.Empty));
            });

            FilesLoaded.Text = "Files Loaded: " + folderResults.Items.Count.ToString();
            folderResults.EndUpdate();
        }

        private void SearchResultsText_MouseClick(object sender, MouseEventArgs e)
        {
            SearchResultsText.Text = string.Empty;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
