using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder.OrderBuilder
{
    public class Director
    {
        public void Construct(IOrderBuilder orderBuilder, string product, 
            string client, string address, string invoiceData)
        {
            orderBuilder.SetClient(client, address);
            orderBuilder.SetProduct(product);
            orderBuilder.SetInvoiceData(invoiceData);
        }
    }
}
