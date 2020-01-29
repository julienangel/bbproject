using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueByte.ViewModel.Models.XML
{
    public class PositionXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float X { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Y { get; set; }
    }
}
