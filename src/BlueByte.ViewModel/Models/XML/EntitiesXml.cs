using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlueByte.ViewModel.Models.XML
{
    [SerializableAttribute()]
    [XmlRoot(Namespace = "", IsNullable = false,ElementName = "Entities")]
    public class EntitiesXml
    {
        [XmlElementAttribute("Entity")]
        public EntityXml[] Entity { get; set; }
    }
}
