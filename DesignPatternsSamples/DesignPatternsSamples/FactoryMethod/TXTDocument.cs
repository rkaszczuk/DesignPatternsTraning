using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.FactoryMethod
{
    public class TXTDocument : IDocument
    {
        private string fileExtension;
        public void SaveString(string content, string filename)
        {
            System.IO.File.WriteAllText($"{filename}.{fileExtension}", content);
            Console.WriteLine("Saved TXT file");
        }

        public void SetFileExtension(string fileExtension)
        {
            this.fileExtension = fileExtension;
        }
    }
}
