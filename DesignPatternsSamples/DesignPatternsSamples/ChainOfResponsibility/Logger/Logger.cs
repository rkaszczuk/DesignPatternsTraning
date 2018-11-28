using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.ChainOfResponsibility.Logger
{
    public enum LogLevel { Debug, Warning, Error}
    public abstract class Logger
    {
        protected LogLevel logLevel;
        protected Logger higherLogger;
        public void SetHigherLogger(Logger logger)
        {
            higherLogger = logger;
        }
        public virtual void Log(Exception ex, LogLevel exLogLevel)
        {
            if(exLogLevel >= logLevel)
            {
                Console.WriteLine($"{logLevel.ToString()} {ex.Message}");
                if (higherLogger != null)
                {
                    higherLogger.Log(ex, exLogLevel);
                }
            }
            

        }
    }
}
