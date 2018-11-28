using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.FactoryMethod
{
    public class PDFDocumentCreator : DocumentCreatorAbstract
    {
        public override IDocument GetDocument()
        {
            var pdfDocument = new PDFDocument();
            pdfDocument.SetFileExtension("pdf");
            return pdfDocument;
        }
    }
}
