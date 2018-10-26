using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeasingSystemToRefactor.Parser
{
    public class JsonParser
    {
        public string Parse<T>(T obj, JsonSerializerSettings jsonSerializerSettings)
        {
            return JsonConvert.SerializeObject(obj, jsonSerializerSettings);
        }
    }
}
