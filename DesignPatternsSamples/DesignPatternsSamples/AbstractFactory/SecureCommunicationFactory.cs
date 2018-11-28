using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public class SecureCommunicationFactory : ICommunicationFactory
    {
        public IFTPCommunication GetFTPCommunication(bool? isSSH)
        {
            if (isSSH.Value)
            {
                return new SSHFileProtocol();
            }
            else
            {
                return new SFTPCommunication();
            }
        }

        public IWebCommunication GetWebCommunication()
        {
            return new HTTPSWebCommunication();
        }
    }
}
