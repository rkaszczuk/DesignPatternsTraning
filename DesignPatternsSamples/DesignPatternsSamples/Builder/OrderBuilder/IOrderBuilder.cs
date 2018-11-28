using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder.OrderBuilder
{
    public interface IOrderBuilder
    {
        void SetProduct(string product);
        void SetClient(string client, string address);
        void SetInvoiceData(string invoiceData);
        Order GetResult();
    }
}
