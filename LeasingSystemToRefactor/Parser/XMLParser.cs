using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LeasingSystemToRefactor.Parser
{
    public class XMLParser
    {
        public string Parse<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            string result = String.Empty;
            using(var sw = new StringWriter())
            {
                using(XmlWriter xmlWriter = XmlWriter.Create(sw))
                {
                    xmlSerializer.Serialize(xmlWriter, obj);
                    result = sw.ToString();
                }
            }
            return result;
        }
    }
}
