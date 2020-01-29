using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlueByte.Infrastructure.Utils.Helpers
{
    public static class XmlManager
    {
        public static string Serialize<T>(T data)
        {
            try
            {
                var stringWriter = new StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringWriter, data);
                return stringWriter.ToString();
            }
            catch
            {
                throw;
            }
        }

        public static T Deserialize<T>(string xml)
        {
            try
            {
                var stringReader = new StringReader(xml);
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
            catch
            {
                throw;
            }
        }
    }
}
