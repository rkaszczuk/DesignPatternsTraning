using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Flyweight
{
    public class PDFDocument : IDocument
    {
        public string Content { get; set; }
        public PDFDocument()
        {
            System.Threading.Thread.Sleep(2000);
            Content = "ABC";
        }
    }
}
