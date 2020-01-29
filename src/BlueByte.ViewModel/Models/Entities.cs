using System.Collections.Generic;

namespace BlueByte.ViewModel.Models
{
    public class Entities
    {
        [System.Xml.Serialization.XmlElementAttribute("Entity")]
        public List<Entity> Entity { get; set; }
    }
}
