using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Flyweight
{
    public class TextHeader : ITextPart
    {
        private string content { get; set; }
        public TextHeader()
        {
            for (int i = 0; i < 5000; i++)
            {
                content += "Header"+i;
            }
        }
        public string GetText()
        {
            return content;
        }
    }
}
