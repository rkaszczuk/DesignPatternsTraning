using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder.OrderBuilder
{
    public class CompanyClientBuilder
    {
        private Order order;
        public void SetClient(string client, string address)
        {
            order.Client = client;
            order.Address = address;
            order.IsCompany = true;
        }

        public void SetInvoiceData(string invoiceData)
        {
            order.InvoiceData = invoiceData;
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
