using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Adapter
{
    public class SFTPConnectionAdapter : IConnection
    {
        SFTPConnection sftpConnection;
        public SFTPConnectionAdapter(SFTPConnection sFTPConnection)
        {
            this.sftpConnection = sFTPConnection;
        }
        public void DeleteFile(string path)
        {
            sftpConnection.DeleteFile(path);
        }

        public byte[] DownloadFile(string path)
        {
            return sftpConnection.GetFile(path);
        }

        public void UploadFile(string path, byte[] content)
        {
            sftpConnection.SaveFile(path, content);
        }
    }
}
