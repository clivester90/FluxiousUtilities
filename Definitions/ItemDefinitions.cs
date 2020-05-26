using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheUtility.Cache
{
    public class ItemDefinitions
    {

        public void ReadBytes(string path)
        {
            byte[] byteArray = File.ReadAllBytes(path + "/obj.idx");
            Console.WriteLine(byteArray);
        }
    }
}
