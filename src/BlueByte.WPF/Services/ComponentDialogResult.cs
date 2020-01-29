using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.Services.Interface.Interfaces;

namespace BlueByte.WPF.Services
{
    public class ComponentDialogResult : IComponentDialogResult
    {
        public EComponentType Type { get; set; }

        public ComponentDialogResult(EComponentType type)
        {
            Type = type;
        }
    }
}
