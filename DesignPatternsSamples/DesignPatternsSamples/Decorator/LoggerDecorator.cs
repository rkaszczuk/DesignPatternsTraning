using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsSamples.Proxy;

namespace DesignPatternsSamples.Decorator
{
    public class LoggerDecorator : DBOperationsDecorator
    {
        public LoggerDecorator(IDBOperations dBOperations) : base(dBOperations)
        {
        }
        public override void Insert(User newRecord)
        {
            base.Insert(newRecord);
            Console.WriteLine("Inserted record");
        }
    }
}
