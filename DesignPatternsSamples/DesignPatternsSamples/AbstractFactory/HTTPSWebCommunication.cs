using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public class HTTPSWebCommunication : IWebCommunication
    {
        public void Delete(string url)
        {
            throw new NotImplementedException();
        }

        public void Get(string url)
        {
            throw new NotImplementedException();
        }

        public void Post(string url)
        {
            throw new NotImplementedException();
        }

        public void Put(string url)
        {
            throw new NotImplementedException();
        }
    }
}
