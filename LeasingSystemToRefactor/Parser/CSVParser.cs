using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Parser
{
    public class CSVParser : ISerializer
    {
        private string delimiter;
        public CSVParser(string delimiter)
        {
            this.delimiter = delimiter;
        }
        public string Parse<T>(T obj)
        {
            string result = String.Empty;
            foreach(var prop in obj.GetType().GetProperties())
            {
                result += prop.GetValue(obj).ToString() + delimiter;
            }
            return result;
        }
    }
}
