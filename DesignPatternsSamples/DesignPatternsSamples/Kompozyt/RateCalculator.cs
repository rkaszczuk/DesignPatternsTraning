using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Kompozyt
{
    public class RateCalculator
    {
        public decimal GetMonthRate(int numberOfRates, ISumable products)
        {
            return products.GetSum() / numberOfRates;
        }
    }
}
