using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Services.Interface.Interfaces;
using GalaSoft.MvvmLight.Ioc;

namespace BlueByte.Infrastructure.ContainerBootstrapper
{
    public static class SimpleIocContainerBootstrapper
    {
        public static void Register(ISimpleIoc services)
        {
            //services.Register<IDialogService, DialogService>();
        }
    }
}
