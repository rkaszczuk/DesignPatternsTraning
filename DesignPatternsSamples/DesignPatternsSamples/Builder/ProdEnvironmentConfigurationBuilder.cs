using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder
{
    public class ProdEnvironmentConfigurationBuilder : IEnvironmentConfigurationBuilder
    {
        private EnvironmentConfiguration environmentConfiguration = new EnvironmentConfiguration();
        public EnvironmentConfiguration GetResult()
        {
            return environmentConfiguration;
        }

        public void SetConfiguration()
        {
            environmentConfiguration.DbConnectionString = "dbprod/prod:prod";
            environmentConfiguration.ErrorNotificationMail = "error@example.com";
            environmentConfiguration.LogLevel = LogLevel.Warning;
        }

        public void SetEnvirementName()
        {
            environmentConfiguration.EnvironmentName = "PROD";
        }
    }
}
