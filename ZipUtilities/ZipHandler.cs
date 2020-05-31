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
    public class ZipHandler
    {

        public void CreateZipFile(string directory, string folderName) {
            Zip zip = new Zip();
            zip.Create(Path.Combine(directory, folderName + ".zip"));
            zip.AddDirectory(directory, true);
            zip.DeleteFile(Path.Combine(folderName, folderName + ".zip"));
            zip.Close();
        }
    }
}
