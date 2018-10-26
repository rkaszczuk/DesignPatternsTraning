using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeasingSystemToRefactor.Parser
{
    public class JsonParser : ISerializer
    {
        private JsonSerializerSettings serializerSettings;
        public JsonParser(JsonSerializerSettings  jsonSerializerSettings)
        {
            serializerSettings = jsonSerializerSettings;
        }
        public string Parse<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, serializerSettings);
        }
    }
}
