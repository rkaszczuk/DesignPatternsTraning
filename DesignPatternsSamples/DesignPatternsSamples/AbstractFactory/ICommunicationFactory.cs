using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.AbstractFactory
{
    public interface ICommunicationFactory
    {
        IWebCommunication GetWebCommunication();
        IFTPCommunication GetFTPCommunication(bool? isSSH);
    }
}
