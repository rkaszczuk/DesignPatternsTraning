using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Strategy
{
    public class BaseSaleStrategy : ISaleStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice;
        }
    }
}
