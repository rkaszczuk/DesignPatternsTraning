using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder
{
    public enum LogLevel { Debug, Warning, Error}
    public class EnvironmentConfiguration
    {
        public string EnvironmentName { get; set; }
        public string DbConnectionString { get; set; }
        public string ErrorNotificationMail { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
