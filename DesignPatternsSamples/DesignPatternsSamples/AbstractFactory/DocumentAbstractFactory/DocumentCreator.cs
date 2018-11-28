using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory.DocumentAbstractFactory
{
    public class DocumentCreator
    {
        static Dictionary<bool, Func<IDocumentFactory>> Options = new Dictionary<bool, Func<IDocumentFactory>>()
        {
            { true, () => new NewOfficeFactory() },
            { false, () => new OldOfficeFactory() }
        };
        public IDocumentFactory GetDocumentFactory(bool isNewOffice)
        {
            return Options[isNewOffice]();
            /*if (isNewOffice)
            {
                return new NewOfficeFactory();
            }
            else
            {
                return new OldOfficeFactory();
            }*/
        }
    }
}
