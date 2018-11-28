using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DesignPatternsSamples.FactoryMethod
{
    public class PDFDocument : IDocument
    {
        private string fileExtension;
        public void SaveString(string content, string filename)
        {
            System.IO.File.WriteAllText($"{filename}.{fileExtension}", content);
            Console.WriteLine("Saved PDF file");
        }

        public void SetFileExtension(string fileExtension)
        {
            this.fileExtension = fileExtension;
        }
    }
}
