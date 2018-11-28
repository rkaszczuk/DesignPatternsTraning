using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Flyweight
{
    public class FlyweightCache
    {
        private Dictionary<string, IDocument> cache = new Dictionary<string, IDocument>();
        public IDocument GetPDFDocument(string key)
        {
            if (!cache.ContainsKey(key))
            {
                cache.Add(key, new PDFDocument());
            }
            return cache[key];
        }
        public IDocument GetWordDocument(string key)
        {
            if (!cache.ContainsKey(key))
            {
                cache.Add(key, new WordDocument());
            }
            return cache[key];
        }
    }
}
