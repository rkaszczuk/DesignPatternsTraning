using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public class CommunicationFactoryCreator
    {
        public static ICommunicationFactory GetCommunicationFactory(bool isSecureProtocol)
        {
            if (isSecureProtocol)
            {
                return new SecureCommunicationFactory();
            }
            else
            {
                return new UnsecureCommunicationFactory();
            }
        }
    }
}
