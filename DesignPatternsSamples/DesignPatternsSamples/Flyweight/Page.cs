using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Flyweight
{
    public class Page
    {
        public ITextPart Header { get; set; }
        public string Content { get; set; }
        public ITextPart Footer { get; set; }
        public string GetPageText()
        {
            return Header.GetText() + Content + Footer.GetText();
        }
    }
}
