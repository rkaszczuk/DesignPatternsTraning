using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.NullObject
{
    public class NullObjectCommunication : ICommunication
    {
        public string LoadFile(string path)
        {
            return String.Empty;
        }

        public void SaveFile(string path, string content)
        {
            return;
        }
    }
}
