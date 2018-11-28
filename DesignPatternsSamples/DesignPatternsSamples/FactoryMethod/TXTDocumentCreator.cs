using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.FactoryMethod
{
    public class TXTDocumentCreator : DocumentCreatorAbstract
    {
        public override IDocument GetDocument()
        {
            var txtDocument = new TXTDocument();
            txtDocument.SetFileExtension("txt");
            return txtDocument;
        }
    }
}
