using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Adapter
{
    public class FTPConnectionAdapter : IConnection
    {
        private FTPConnection ftpConnection = new FTPConnection();
        public void DeleteFile(string path)
        {
            ftpConnection.DeleteFile(path);
        }

        public byte[] DownloadFile(string path)
        {
            return Encoding.Unicode.GetBytes(ftpConnection.DownloadFile(path));
        }

        public void UploadFile(string path, byte[] content)
        {
            ftpConnection.UploadFile(path, Encoding.Unicode.GetString(content));
        }
    }
}
