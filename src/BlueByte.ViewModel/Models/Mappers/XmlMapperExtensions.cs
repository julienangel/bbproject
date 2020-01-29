using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Extensions;
using BlueByte.ViewModel.Models.XML;

namespace BlueByte.ViewModel.Models.Mappers
{
    public static class XmlMapperExtensions
    {
        public static List<Entity> ToViewModel(this EntitiesXml entityXml)
        {
            return entityXml.Entity.Select(xml => xml.ToViewModel()).ToList();
        }

        public static Entity ToViewModel(this EntityXml entityXml)
        {
            return new Entity()
            {
                Name = entityXml.Name,
                Asset = entityXml.Asset?.ToViewModel(),
                Behavior = entityXml.Behavior?.ToViewModel(),
                Position = entityXml.Position?.ToViewModel()
            };
        }

        public static Asset ToViewModel(this AssetXml asset)
        {
            return new Asset()
            {
                Filename = asset.Filename
            };
        }

        public static Position ToViewModel(this PositionXml position)
        {
            return new Position()
            {
                X = position.X,
                Y = position.Y
            };
        }

        public static Behavior ToViewModel(this BehaviorXml behavior)
        {
            return new Behavior()
            {
                Type = behavior.Type.ToBehavior()
            };
        }
    }
}
