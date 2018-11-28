using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory.DocumentAbstractFactory
{
    public interface IDocumentFactory
    {
        IWordDocument GetWordDocument();
        IExcelDocument GetExcelDocument();
    }
}
