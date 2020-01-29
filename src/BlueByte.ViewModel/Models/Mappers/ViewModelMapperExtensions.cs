using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Extensions;
using BlueByte.ViewModel.Models.XML;

namespace BlueByte.ViewModel.Models.Mappers
{
    public static class MapperExtensions
    {
        public static EntitiesXml ToXml(this List<Entity> entityList)
        {
            return new EntitiesXml { Entity = entityList.Select(entity => entity.ToXml()).ToArray() };
        }

        public static EntityXml ToXml(this Entity entity)
        {
            return new EntityXml()
            {
                Name = entity.Name,
                Asset = entity.Asset.ToXml(),
                Behavior = entity.Behavior.ToXml(),
                Position = entity.Position.ToXml()
            };
        }

        public static AssetXml ToXml(this Asset asset)
        {
            if (asset == null)
                return null;

            return new AssetXml()
            {
                Filename = asset.Filename
            };
        }

        public static PositionXml ToXml(this Position position)
        {
            if (position == null)
                return null;

            return new PositionXml
            {
                X = position.X,
                Y = position.Y
            };
        }

        public static BehaviorXml ToXml(this Behavior behavior)
        {
            if (behavior == null)
                return null;

            return new BehaviorXml()
            {
                Type = behavior.Type.ToString()
            };
        }
    }
}
