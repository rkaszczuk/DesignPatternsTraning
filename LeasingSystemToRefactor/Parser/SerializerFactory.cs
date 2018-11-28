using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Parser
{
    public enum SerializerType { CsvDot, CsvComma, CsvTab, Json, Xml }
    public class SerializerFactory
    {
        private JsonSerializerSettings GetDefaultJsonConfiguration()
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            return jsonSerializerSettings;
        }
        public ISerializer GetSerializer(SerializerType serializerType)
        {
            switch (serializerType)
            {
                case SerializerType.CsvDot:
                    return new CSVParser(".");
                case SerializerType.CsvComma:
                    return new CSVParser(",");
                case SerializerType.CsvTab:
                    return new CSVParser("\t");
                case SerializerType.Json:
                    return new JsonParser(GetDefaultJsonConfiguration());
                case SerializerType.Xml:
                    return new XMLParser();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
