using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Kompozyt.FileSystem
{
    public class Folder : IFileSystem
    {
        public List<IFileSystem> Files = new List<IFileSystem>();
        public string Path { get; set; }
        public void Create()
        {
            System.IO.Directory.CreateDirectory(Path);
            foreach(var file in Files)
            {
                file.Create();
            }
        }

        public void Delete()
        {
            foreach (var file in Files)
            {
                file.Delete();
            }
            System.IO.Directory.Delete(Path);
        }
    }
}
