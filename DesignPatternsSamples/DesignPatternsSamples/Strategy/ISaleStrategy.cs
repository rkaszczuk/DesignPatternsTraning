using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Strategy
{
    public interface ISaleStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }
}
