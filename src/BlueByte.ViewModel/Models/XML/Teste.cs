using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueByte.ViewModel.Models.XML
{
    class Teste
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Entities
        {

            private EntitiesEntity[] entityField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Entity")]
            public EntitiesEntity[] Entity
            {
                get
                {
                    return this.entityField;
                }
                set
                {
                    this.entityField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EntitiesEntity
        {

            private EntitiesEntityAsset assetField;

            private EntitiesEntityPosition positionField;

            private EntitiesEntityBehavior behaviorField;

            private string nameField;

            /// <remarks/>
            public EntitiesEntityAsset Asset
            {
                get
                {
                    return this.assetField;
                }
                set
                {
                    this.assetField = value;
                }
            }

            /// <remarks/>
            public EntitiesEntityPosition Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            public EntitiesEntityBehavior Behavior
            {
                get
                {
                    return this.behaviorField;
                }
                set
                {
                    this.behaviorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EntitiesEntityAsset
        {

            private string filenameField;

            /// <remarks/>
            public string Filename
            {
                get
                {
                    return this.filenameField;
                }
                set
                {
                    this.filenameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EntitiesEntityPosition
        {

            private byte xField;

            private decimal yField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte X
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EntitiesEntityBehavior
        {

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }



    }
}
