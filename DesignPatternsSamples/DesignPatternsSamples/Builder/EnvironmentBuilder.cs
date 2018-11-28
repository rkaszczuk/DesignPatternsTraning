using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder
{
    public class EnvironmentBuilder
    {
        private EnvironmentConfiguration environmentConfiguration;
        public EnvironmentBuilder()
        {
            environmentConfiguration = new EnvironmentConfiguration();
        }
        public EnvironmentBuilder SetEnvironmentName(string environmentName)
        {
            if(environmentName != "PROD" || environmentName != "TEST")
            {
                throw new NotSupportedException();
            }
            this.environmentConfiguration.EnvironmentName = environmentName;
            return this;
        }
        public EnvironmentBuilder SetLogLevel(LogLevel logLevel)
        {
            this.environmentConfiguration.LogLevel = logLevel;
            return this;
        }
        public EnvironmentBuilder SetNotificationMail(string notificationMail)
        {
            this.environmentConfiguration.ErrorNotificationMail = notificationMail;
            return this;
        }
        public EnvironmentConfiguration Build()
        {
            if(environmentConfiguration.EnvironmentName != null)
            {

            }
            return environmentConfiguration;
        }
    }
}
