using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;
using BlueByte.ViewModel.Models.Interfaces;
using GalaSoft.MvvmLight;

namespace BlueByte.ViewModel.Models
{
    public class Asset : ViewModelBase, IComponent
    {
        private string _filename;
        public string Filename
        {
            get { return _filename; }
            set { Set(ref _filename, value); }
        }
        public EComponentType ComponentType => EComponentType.Asset;
    }

}
