using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Visitor
{
    public interface IVisitable
    {
        decimal Accept(IVisitor visitor);
    }
}
