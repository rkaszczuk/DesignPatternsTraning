using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility.Logger
{
    public class ErrorLogger : Logger
    {
        public ErrorLogger()
        {
            logLevel = LogLevel.Error;
        }
        public override void Log(Exception ex, LogLevel exLogLevel)
        {
            if (exLogLevel >= logLevel)
            {
                Console.WriteLine($"[UWAGA]!!!!! {logLevel.ToString()} {ex.Message}");
                if (higherLogger != null)
                {
                    higherLogger.Log(ex, exLogLevel);
                }
            }
        }
    }
}
