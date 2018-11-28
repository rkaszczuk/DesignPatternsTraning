using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder.OrderBuilder
{
    public class IndividualClientBuilder : IOrderBuilder
    {
        private Order order;
        public void SetClient(string client, string address)
        {
            order.Client = client;
            order.Address = address;
            order.IsCompany = false;
        }

        public void SetInvoiceData(string invoiceData)
        {
            return;
        }

        public void SetProduct(string product)
        {
            order.Product = product;
        }
        public Order GetResult()
        {
            return order;
        }

    }
}
