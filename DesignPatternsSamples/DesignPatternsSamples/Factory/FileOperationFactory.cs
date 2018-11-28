using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Factory
{
    public class FileOperationFactory
    {
        public static IFileOperation GetFileOperation(string protocol)
        {
            if(protocol == "FTP")
            {
                return new FTPFileOperation();
            }
            else if (protocol == "FILESYSTEM")
            {
                return new FileSystemOperation();
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
