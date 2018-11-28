using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Adapter
{
    public class SFTPConnection
    {
        public void SaveFile(string path, byte[] content)
        {

        }
        public byte[] GetFile(string path)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(string path) { }
    }
}
