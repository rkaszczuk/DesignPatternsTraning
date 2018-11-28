using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.NullObject
{
    public interface ICommunication
    {
        void SaveFile(string path, string content);
        string LoadFile(string path);
    }
}
