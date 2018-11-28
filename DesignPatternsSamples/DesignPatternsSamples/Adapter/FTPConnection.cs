using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Adapter
{
    public class FTPConnection
    {
        public void UploadFile(string path, string fileContent)
        {

        }
        public string DownloadFile(string path)
        {
            throw new NotImplementedException();
        }
        public void DeleteFile(string path)
        {

        }
    }
}
