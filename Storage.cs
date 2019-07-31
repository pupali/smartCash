using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.StorageManagmentEntities
{
    public class Storage:INotifyPropertyChanged
    {
        private int _id;
        public int id
        {
            get
            { return _id; }
            set
            {
                if (value == _id) return;
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _storageName;
        public string storageName
        {
            get
            { return _storageName; }
            set
            {
                if (value == _storageName) return;
                _storageName = value;
                OnPropertyChanged();
            }
        }

        private string _storageAddress;
        public string storageAddress
        {
            get
            { return _storageAddress; }
            set
            {
                if (value == _storageAddress) return;
                _storageAddress = value;
                OnPropertyChanged();
            }
        }

        private string _storagePhone;

        public event PropertyChangedEventHandler PropertyChanged;

        public string storagePhone
        {
            get
            { return _storagePhone; }
            set
            {
                if (value == _storagePhone) return;
                _storagePhone = value;
                OnPropertyChanged();
            }
        }

        

        public virtual ObservableCollection<StoredProduct> products { get; set; }

        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

