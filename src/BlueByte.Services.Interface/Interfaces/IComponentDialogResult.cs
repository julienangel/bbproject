using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;

namespace BlueByte.Services.Interface.Interfaces
{
    public interface IComponentDialogResult
    {
        EComponentType Type { get; set; }
    }
}
