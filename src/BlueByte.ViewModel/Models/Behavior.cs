using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.ViewModel.Models.Interfaces;

namespace BlueByte.ViewModel.Models
{
    public class Behavior : IComponent
    {
        public EBehavior Type { get; set; }

        public EComponentType ComponentType => EComponentType.Behavior;

        public IEnumerable<EBehavior> Behaviors => Enum.GetValues(typeof(EBehavior)).Cast<EBehavior>();

    }
}
