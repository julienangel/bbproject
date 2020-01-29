using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;

namespace BlueByte.ViewModel.Models.Interfaces
{
    public interface IComponent
    {
        EComponentType ComponentType { get; }
    }
}
