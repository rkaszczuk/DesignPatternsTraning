using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Strategy
{
    public class BlackFridayStrategy : ISaleStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 0.99M;
        }
    }
}
