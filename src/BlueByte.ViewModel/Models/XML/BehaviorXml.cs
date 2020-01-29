using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueByte.ViewModel.Models.XML
{
    public class BehaviorXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }
    }
}
