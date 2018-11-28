using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility.Logger
{
    public class WarningLogger : Logger
    {
        public WarningLogger()
        {
            logLevel = LogLevel.Warning;
        }
    }
}
