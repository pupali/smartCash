using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.StorageManagmentEntities
{
    public partial class Storage : INotifyPropertyChanged
    {
        public int id
        {
            get
            { return idS; }
            set
            {
                if (value == idS) return;
                idS = value;
                OnPropertyChanged();
            }
        }
        public string storageName
        {
            get
            { return storageNameS; }
            set
            {
                if (value == storageNameS) return;
                storageNameS = value;
                OnPropertyChanged();
            }
        }
        public string storageAddress
        {
            get
            { return storageAddressS; }
            set
            {
                if (value == storageAddressS) return;
                storageAddressS = value;
                OnPropertyChanged();
            }
        }
        public string storagePhone
        {
            get
            { return storagePhoneS; }
            set
            {
                if (value == storagePhoneS) return;
                storagePhoneS = value;
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
