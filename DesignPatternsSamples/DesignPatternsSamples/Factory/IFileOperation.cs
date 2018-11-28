using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Factory
{
    public interface IFileOperation
    {
        string ReadFile(string path);
        void SaveFile(string path, string content);
        void DeleteFile(string path);
    }
}
