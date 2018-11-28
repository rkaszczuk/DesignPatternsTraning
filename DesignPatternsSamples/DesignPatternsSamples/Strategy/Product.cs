using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Strategy
{
    public class Product
    {
        private ISaleStrategy saleStrategy;
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Product(ISaleStrategy saleStrategy)
        {
            this.saleStrategy = saleStrategy;
        }

        public decimal GetTotalPrice()
        {
            
            var basePrice = Price * Count;
            return saleStrategy.CalculatePrice(basePrice);
        }
    }
}
