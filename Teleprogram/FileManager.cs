using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Teleprogram
{
    public class FileManager
    {
        public void CreateDirectory()
        {
            string directoryPath = @"C:\Temp";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(@"C:\Temp");
            }
        }

        public void CreateFile()
        {
            var stream = File.Create(@"C:\Temp\TeleprogramsDb.txt");
            stream.Close();
        }
    }
}
