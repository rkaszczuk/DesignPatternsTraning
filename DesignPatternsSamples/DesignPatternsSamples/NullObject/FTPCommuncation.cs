using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.NullObject
{
    public class FTPCommuncation : ICommunication
    {
        public string LoadFile(string path)
        {
            return "FTPContent";
        }

        public void SaveFile(string path, string content)
        {
            Console.WriteLine("FTP - SAVED FILE");
        }
    }
}
