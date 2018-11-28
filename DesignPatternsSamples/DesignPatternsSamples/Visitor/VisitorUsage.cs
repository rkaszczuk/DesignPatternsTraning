using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Visitor
{
    public static class VisitorUsage
    {
        public static void Run()
        {
            List<IVisitable> products = new List<IVisitable>()
            {
                new Product(){ Ammount = 10, Price = 3},
                new Product(){ Ammount = 1, Price = 50},
                new ProductWithWeight() { Weight = 0.5m, PricePerKg = 40}
            };
            IVisitor visitor = new ShopingCartVisitor();
            foreach(var product in products)
            {
                Console.WriteLine(product.Accept(visitor));
            }
        }
    }
}
