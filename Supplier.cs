using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.SuppliersManagmentEntities
{
    public class Supplier:INotifyPropertyChanged
    {
        private int _id;
        [Key]
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

        private string _suplierName;
        public string suplierName
        {
            get
            { return _suplierName; }
            set
            {
                if (value == _suplierName) return;
                _suplierName = value;
                OnPropertyChanged();
            }
        }

        private string _address;
        public string address
        {
            get
            { return _address; }
            set
            {
                if (value == _address) return;
                _address = value;
                OnPropertyChanged();
            }
        }

        private string _phoneNumber;
        public string phoneNumber
        {
            get
            { return _phoneNumber; }
            set
            {
                if (value == _phoneNumber) return;
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
