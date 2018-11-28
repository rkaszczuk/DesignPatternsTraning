using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Bridge
{
    public interface IFileTransfer
    {
        void UploadFile(string localPath, string remotePath);
        void DownloadFile(string remotePath, string localPath);
    }
}
