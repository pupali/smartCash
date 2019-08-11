using SmartCasherProject.Entities.UsersManagmentEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public partial class Module : INotifyPropertyChanged
    {
        public int id
        {
            get
            { return idU; }
            set
            {
                if (value == idU) return;
                idU = value;
                OnPropertyChanged();
            }
        }
        public string moduleName
        {
            get
            { return moduleNameU; }
            set
            {
                if (value == moduleNameU) return;
                moduleNameU = value;
                OnPropertyChanged();
            }
        }
        public string moduleDescription
        {
            get
            { return moduleDescriptionU; }
            set
            {
                if (value == moduleDescriptionU) return;
                moduleDescriptionU = value;
                OnPropertyChanged();
            }
        }

       
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
