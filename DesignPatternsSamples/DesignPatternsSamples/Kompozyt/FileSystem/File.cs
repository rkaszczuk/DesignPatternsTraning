using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Kompozyt.FileSystem
{
    public class File : IFileSystem
    {
        public string Path { get; set; }

        public void Create()
        {
            System.IO.File.Create(Path);
        }

        public void Delete()
        {
            System.IO.File.Delete(Path);
        }
    }
}
