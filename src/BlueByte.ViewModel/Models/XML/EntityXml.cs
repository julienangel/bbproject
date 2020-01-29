using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlueByte.ViewModel.Models.XML
{
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EntityXml
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
        public AssetXml Asset { get; set; }
        public PositionXml Position { get; set; }
        public BehaviorXml Behavior { get; set; }
    }
}
