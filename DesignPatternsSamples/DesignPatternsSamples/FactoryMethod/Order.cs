using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.FactoryMethod
{
    public class Order
    {
        public string Product { get; set; }
        public string User { get; set; }
        public string InvoiceData { get; set; }
        public string Bonus { get; set; }
        public Order(string product, string user)
        {

        }      
        //public Order(string product, string user, string address) { }
        //public Order(string product, string user, string invoiceData) { }
        //public Order(string product, string user, string address, string invoiceData) { }
        //public Order(string product, string user, string address, string invoiceData, string bonus) { }*/
        //public static Order GetOrderWithoutDelivery(string product, string user)
        //{
        //    var result = new Order { Product = product, User = user };
        //    return result;
        //}
        //public static Order GetOrderWithDeliveryAndInvoice(string product, string user, string address, string invoiceData)
        //{ }

    }
}
