using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public class SFTPCommunication : IFTPCommunication
    {
        public void DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public void DownloadFile(string filePath)
        {
            Console.WriteLine("SFTP - DownloadFile");
        }

        public void UploadFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
