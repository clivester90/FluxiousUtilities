using ComponentPro.Compression;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace CacheUtility.ZipUtilities
{
    public class DirectoryHandler
    {

        public IEnumerable<string> filesFound;

        public void LocateFilesInDirectory(string directory)
        {
            filesFound = Directory.GetFiles(directory, "*", SearchOption.AllDirectories).Where(x => x.EndsWith(".jar"));
        }

        public void CreateZipFile(string directory, string folderName) {
            ZipFile.CreateFromDirectory(directory, folderName + ".zip");
        }
    }
}
