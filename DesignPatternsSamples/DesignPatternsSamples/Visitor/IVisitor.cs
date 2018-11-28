using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Visitor
{
    public interface IVisitor
    {
        decimal Visit(Product product);
        decimal Visit(ProductWithWeight product);
    }
}
