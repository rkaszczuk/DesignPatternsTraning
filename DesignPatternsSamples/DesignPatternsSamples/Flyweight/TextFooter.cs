using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Flyweight
{
    public class TextFooter : ITextPart
    {
        private string content { get; set; }
        public TextFooter()
        {
            for (int i = 0; i < 5000; i++)
            {
                content += "Footer"+i;
            }
        }
        public string GetText()
        {
            return content;
        }
    }
}
