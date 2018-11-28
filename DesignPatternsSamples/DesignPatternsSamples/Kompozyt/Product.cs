using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Kompozyt
{
    public class Product : ISumable
    {
        public decimal Price { get; set; }
        public decimal GetSum()
        {
            return Price;
        }
    }
}
