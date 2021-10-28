using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\tmp\soppa.txt";
            File.Copy(@"C:\tmp\ostkaka.txt", @"C:\tmp\apfanskap.txt", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //something
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("..");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //something

            }


        }
    }
}
