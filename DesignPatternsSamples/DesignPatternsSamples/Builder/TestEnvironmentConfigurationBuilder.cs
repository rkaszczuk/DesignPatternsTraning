using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder
{
    public class TestEnvironmentConfigurationBuilder : IEnvironmentConfigurationBuilder
    {
        private EnvironmentConfiguration environmentConfiguration = new EnvironmentConfiguration();
        public EnvironmentConfiguration GetResult()
        {
            return environmentConfiguration;
        }

        public void SetConfiguration()
        {
            environmentConfiguration.DbConnectionString = "dbTest/Test:Test";
            environmentConfiguration.ErrorNotificationMail = "test@example.com";
            environmentConfiguration.LogLevel = LogLevel.Debug;
        }

        public void SetEnvirementName()
        {
            environmentConfiguration.EnvironmentName = "Test";
        }
    }
}
