using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility.Logger
{
    public class DebugLogger : Logger
    {
        public DebugLogger()
        {
            logLevel = LogLevel.Debug;
        }
    }
}
