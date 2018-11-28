using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Adapter
{
    public interface IConnection
    {
        void UploadFile(string path, byte[] content);
        byte[] DownloadFile(string path);
        void DeleteFile(string path);
    }
}
