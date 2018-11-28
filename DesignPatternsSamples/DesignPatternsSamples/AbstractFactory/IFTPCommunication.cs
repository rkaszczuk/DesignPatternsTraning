using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public interface IFTPCommunication
    {
        void UploadFile(string filePath);
        void DownloadFile(string filePath);
        void DeleteFile(string filePath);
    }
}
