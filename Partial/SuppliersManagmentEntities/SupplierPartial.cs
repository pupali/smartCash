using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.SuppliersManagmentEntities
{
    public partial class Supplier : INotifyPropertyChanged
    {

        [Key]
        public int id
        {
            get
            { return idSu; }
            set
            {
                if (value == idSu) return;
                idSu = value;
                OnPropertyChanged();
            }
        }
        public string suplierName
        {
            get
            { return suplierNameSu; }
            set
            {
                if (value == suplierNameSu) return;
                suplierNameSu = value;
                OnPropertyChanged();
            }
        }
        public string address
        {
            get
            { return addressSu; }
            set
            {
                if (value == addressSu) return;
                addressSu = value;
                OnPropertyChanged();
            }
        }
        public string phoneNumber
        {
            get
            { return phoneNumberSu; }
            set
            {
                if (value == phoneNumberSu) return;
                phoneNumberSu = value;
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
