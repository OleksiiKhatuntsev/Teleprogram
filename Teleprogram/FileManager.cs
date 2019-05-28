using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Teleprogram
{
    public class FileManager
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }
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
            if(File.Exists(filePath))
            { return;}
            var stream = File.Create(filePath);
            stream.Close();
        }

        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}
