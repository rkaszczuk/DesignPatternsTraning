using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Memento.FileMemento
{
    public class Originator
    {
        public string Content { get; set; }
        public string Path { get; set; }

        public void ReadFileContent()
        {
            Content = System.IO.File.ReadAllText(Path);
        }
        public void WriteFileContent()
        {
            System.IO.File.WriteAllText(Path, Content);
        }

        public FileMemento SaveState()
        {
            ReadFileContent();
            return new FileMemento() { Content = Content };
        }
        public void LoadState(FileMemento fileMemento)
        {
            Content = fileMemento.Content;
            WriteFileContent();
        }
        
    }
}
