using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Memento.FileMemento
{
    public class FileCareTaker
    {
        private Dictionary<int, FileMemento> filesRevisions = new Dictionary<int, FileMemento>();
        public int Add(FileMemento fileMemento)
        {
            var revisionNumber = filesRevisions.Count;
            filesRevisions.Add(filesRevisions.Count, fileMemento);
            return revisionNumber;
        }
        public FileMemento Get(int revisionNumber)
        {
            return filesRevisions[revisionNumber];
        }
    }
}
