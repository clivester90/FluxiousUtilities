using ComponentPro.Compression;
using ComponentPro.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheUtility.ZipUtilities
{
    class ZipHandler
    {
        public event EventHandler<FileSystemProgressEventArgs> ProgressUpdated;

        public void CreateZip(string directory, string folderName) {
            Zip zip = new Zip();
            zip.Create(Path.Combine(directory, folderName + ".zip"));
            zip.Progress += ProgressUpdated;
            zip.AddDirectory(directory, true);
            zip.DeleteFile(Path.Combine(folderName, folderName + ".zip"));
            zip.Close();
        }
    }
}
