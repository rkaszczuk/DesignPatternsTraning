using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.NullObject
{
    public class CommunicationFactory
    {
        public static ICommunication GetInstance(string protocol)
        {
            if(protocol == "FS")
            {
                return new FileSystemCommunication();
            }
            else if(protocol == "FTP")
            {
                return new FTPCommuncation();
            }
            else
            {
                return new NullObjectCommunication();
            }
        }
    }
}
