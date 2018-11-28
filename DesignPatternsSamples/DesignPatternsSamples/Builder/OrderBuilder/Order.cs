using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder.OrderBuilder
{
    public class Order
    {
        public string Product { get; set; }
        public string Client { get; set; }
        public string Address { get; set; }
        public bool IsCompany { get; set; }
        public string InvoiceData { get; set; }
    }
}
