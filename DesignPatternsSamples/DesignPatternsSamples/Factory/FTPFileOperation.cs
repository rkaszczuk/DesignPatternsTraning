using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Factory
{
    public class FTPFileOperation : IFileOperation
    {
        public void DeleteFile(string path)
        {
            Console.WriteLine("[FTP] Delete file");
        }

        public string ReadFile(string path)
        {
            throw new NotImplementedException();
        }

        public void SaveFile(string path, string content)
        {
            throw new NotImplementedException();
        }
    }
}
