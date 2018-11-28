using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Visitor
{
    public class Product : IVisitable
    {
        public decimal Price {get;set;}
        public int Ammount { get; set; }
        public decimal Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
