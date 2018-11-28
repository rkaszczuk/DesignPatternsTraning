using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Builder
{
    public interface IEnvironmentConfigurationBuilder
    {
        void SetEnvirementName();
        void SetConfiguration();
        EnvironmentConfiguration GetResult();
    }
}
