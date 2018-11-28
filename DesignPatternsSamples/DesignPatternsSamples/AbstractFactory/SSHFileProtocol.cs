using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public class SSHFileProtocol : IFTPCommunication
    {
        public void DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void DownloadFile(string filePath)
        {
            Console.WriteLine("SSHFileProtocol - DownloadFile");
        }

        public void UploadFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
