using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public interface IWebCommunication
    {
        void Put(string url);
        void Post(string url);
        void Delete(string url);
        void Get(string url);
    }
}
