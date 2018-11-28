using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory.DocumentAbstractFactory
{
    public class NewOfficeFactory : IDocumentFactory
    {
        public IExcelDocument GetExcelDocument()
        {
            return new XlsxDocument();
        }

        public IWordDocument GetWordDocument()
        {
            return new DocxDocument();
        }
    }
}
