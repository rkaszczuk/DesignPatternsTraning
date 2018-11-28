using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Visitor
{
    public class ProductWithWeight : IVisitable
    {
        public decimal Weight { get; set; }
        public decimal PricePerKg { get; set; }
        public decimal Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
