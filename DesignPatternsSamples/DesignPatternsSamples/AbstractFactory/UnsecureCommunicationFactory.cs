using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public class UnsecureCommunicationFactory : ICommunicationFactory
    {
        public IFTPCommunication GetFTPCommunication(bool? isSSH)
        {
            return new FTPCommunication();
        }

        public IWebCommunication GetWebCommunication()
        {
            return new HTTPWebCommunication();
        }
    }
}
