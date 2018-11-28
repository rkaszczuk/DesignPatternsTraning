using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory.DocumentAbstractFactory
{
    public class OldOfficeFactory : IDocumentFactory
    {
        public IExcelDocument GetExcelDocument()
        {
            return new XlsDocument();
        }

        public IWordDocument GetWordDocument()
        {
            return new DocDocument();
        }
    }
}
