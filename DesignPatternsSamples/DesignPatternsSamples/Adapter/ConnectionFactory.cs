using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Adapter
{
    public enum ConnectionType { FTP, SFTP}
    public class ConnectionFactory
    {
        public IConnection GetConnection(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.FTP:
                    return new FTPConnectionAdapter();
                //case ConnectionType.SFTP:
                //    return new SFTPConnectionAdapter();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
