using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Singleton
{
    public class LoggerSingleton
    {
        public void Log(string log)
        {
        }

        private LoggerSingleton()
        {

        }
        private static LoggerSingleton loggerSingleton;

        public static LoggerSingleton GetInstance()
        {
            if(loggerSingleton == null)
            {
                loggerSingleton = new LoggerSingleton();
            }
            return loggerSingleton;
        }
    }
}
