using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Flyweight
{
    public class TextPartFlyweight
    {
        private Dictionary<string, ITextPart> textParts = new Dictionary<string, ITextPart>();
        public TextPartFlyweight()
        {
            textParts.Add("HEADER", new TextHeader());
            textParts.Add("FOOTER", new TextFooter());
        }
        public ITextPart GetTextPart(string id)
        {
            return textParts[id];
        }
    }
}
