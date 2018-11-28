using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Visitor
{
    public class ShopingCartVisitor : IVisitor
    {
        private decimal tax = 0.23M;
        public decimal Visit(Product product)
        {
            return (product.Price * product.Ammount)*(1+tax);
        }

        public decimal Visit(ProductWithWeight product)
        {
            return (product.PricePerKg * product.Weight) * (1 + tax);
        }       
    }
}
