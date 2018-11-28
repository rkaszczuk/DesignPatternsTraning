using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Factory
{
    public class SQLConnectionFactory
    {
        public static SQLConnection GetConnection()
        {
            return new SQLConnection("db/prod:prod");
        }
    }
}
