using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Bridge
{
    public interface IConnection
    {
        void SaveToFile(string content, string remotePath);
        string ReadFromFile(string remotePath);
    }
}
