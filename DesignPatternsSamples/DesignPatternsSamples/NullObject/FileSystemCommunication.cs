using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.NullObject
{
    public class FileSystemCommunication : ICommunication
    {
        public string LoadFile(string path)
        {
            return "FSContent";
        }

        public void SaveFile(string path, string content)
        {
            Console.WriteLine("FS - SAVED FILE");
        }
    }
}
