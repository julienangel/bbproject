using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Services.Interface.Interfaces;
using BlueByte.ViewModel.Annotations;
using GalaSoft.MvvmLight;

namespace BlueByte.ViewModel.ViewModels.Base
{
    public class BaseViewModel : ViewModelBase
    {
        public IDialogService DialogService { get; private set; }

        public BaseViewModel(IDialogService dialogService)
        {
            DialogService = dialogService;
        }
    }
}
