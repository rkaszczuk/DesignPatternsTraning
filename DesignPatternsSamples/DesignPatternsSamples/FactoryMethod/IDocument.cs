using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.FactoryMethod
{
    public interface IDocument
    {
        void SetFileExtension(string fileExtension);
        void SaveString(string content, string filename);
    }
}
