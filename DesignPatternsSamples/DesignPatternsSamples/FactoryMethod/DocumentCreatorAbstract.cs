using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.FactoryMethod
{
    public abstract class DocumentCreatorAbstract
    {
        public abstract IDocument GetDocument();
    }
}
