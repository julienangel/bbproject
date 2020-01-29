using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.Infrastructure.Utils.Extensions;
using BlueByte.ViewModel.Models.Interfaces;

namespace BlueByte.ViewModel.Models
{
    public class Position :  IComponent
    {
        private const short RANGE_MIN = -1000;
        private const short RANGE_MAX = 1000;

        private float _x, _y;

        public float X
        {
            get => _x;
            set => _x = value.Clamp(RANGE_MIN, RANGE_MAX);
        }
        public float Y
        {
            get => _y;
            set => _y = value.Clamp(RANGE_MIN, RANGE_MAX);
        }

        public EComponentType ComponentType => EComponentType.Position;
    }
}
