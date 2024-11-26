using OnlineQuizPlatform.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Helper
{
    internal class FileHelper
    {
        private string filePath;

        public FileHelper(string filePath)
        {
            this.filePath = filePath;
        }

        public void WriteInFile(string message )
        {
            File.WriteAllText(filePath, message);
        }

        public string ReadFromFile()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            return string.Empty;
        }

    }
}
