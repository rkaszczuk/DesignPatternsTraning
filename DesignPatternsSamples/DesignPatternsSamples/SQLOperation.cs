using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples
{
    public interface ILogger
    {
        void WriteLog(string log);
    }
    public class FileLogger : ILogger
    {
        public void WriteLog(string log)
        {
            System.IO.File.WriteAllText("query.log", log);
        }
    }
    public class ConsoleLogger : ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine(log);
        }
    }

    public class SQLOperation
    {
        private ILogger logger;
        public SQLOperation(ILogger logger)
        {
            this.logger = logger;
        }
        public void Execute(string sqlQuery)
        {
            //Some logic
            //System.IO.File.WriteAllText("query.log",sqlQuery);
            logger.WriteLog(sqlQuery);
        }
    }
}
