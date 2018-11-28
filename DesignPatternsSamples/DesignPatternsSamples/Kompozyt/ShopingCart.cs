using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Kompozyt
{
    public class ShopingCart : ISumable
    {
        public List<ISumable> Products { get; set; } = new List<ISumable>();

        public decimal GetSum()
        {
            decimal result = 0;
            foreach(var product in Products)
            {
                result += product.GetSum();
            }
            return result;
        }
    }
}
