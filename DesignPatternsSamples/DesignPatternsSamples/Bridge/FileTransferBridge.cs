using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Bridge
{
    public class FileTransferBridge : IFileTransfer
    {
        private IConnection connection;

        public FileTransferBridge(IConnection connection)
        {
            this.connection = connection;
        }

        public void DownloadFile(string remotePath, string localPath)
        {
            var fileContent = connection.ReadFromFile(remotePath);
            System.IO.File.WriteAllText(localPath,fileContent);
        }

        public void UploadFile(string localPath, string remotePath)
        {
            var fileContent = System.IO.File.ReadAllText(localPath);
            connection.SaveToFile(fileContent, remotePath);
        }
    }
}
