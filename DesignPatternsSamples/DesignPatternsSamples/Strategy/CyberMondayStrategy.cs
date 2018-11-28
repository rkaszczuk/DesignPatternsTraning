using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Strategy
{
    public class CyberMondayStrategy : ISaleStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 1.2m;
        }
    }
}
