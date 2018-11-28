using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder
{
    public class Director
    {
        public void Construct(IEnvironmentConfigurationBuilder environmentConfigurationBuilder)
        {
            environmentConfigurationBuilder.SetConfiguration();
            environmentConfigurationBuilder.SetEnvirementName();
        }
    }
}
