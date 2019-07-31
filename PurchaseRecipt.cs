using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SmartCasherProject.Entities.ProductManagmentEntities;
using SmartCasherProject.Entities.StorageManagmentEntities;

namespace SmartCasherProject.Entities.SuppliersManagmentEntities
{
    public class PurchaseRecipt : IEntityDates,INotifyPropertyChanged
    {
        private long _id;
        [Key]
        public long id
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

        private int _reciptCost;
        public int reciptCost
        {
            get
            { return _reciptCost; }
            set
            {
                if (value == _reciptCost) return;
                _reciptCost = value;
                OnPropertyChanged();
            }
        }

        private ReciptType _type;
        // نوع قائمة الشراء
        public ReciptType type
        {
            get
            { return _type; }
            set
            {
                if (value == _type) return;
                _type = value;
                OnPropertyChanged();
            }
        }

        private int? _cashPayed;
        // كم المدفوع من قيمة القائمة نقديا
        public int? cashPayed
        {
            get
            { return _cashPayed; }
            set
            {
                if (value == _cashPayed) return;
                _cashPayed = value;
                OnPropertyChanged();
            }
        }

        private int? _ammountLeft;
        // كم المتبقي من قيمة القائمة لم يدفع
        public int? ammountLeft
        {
            get
            { return _ammountLeft; }
            set
            {
                if (value == _ammountLeft) return;
                _ammountLeft = value;
                OnPropertyChanged();
            }
        }

        private int _supplierId;
        [ForeignKey("supplier")]
        public int supplierId
        {
            get
            { return _supplierId; }
            set
            {
                if (value == _supplierId) return;
                _supplierId = value;
                OnPropertyChanged();
            }
        }

        private Supplier _supplier;
        public Supplier supplier
        {
            get
            { return _supplier; }
            set
            {
                if (value == _supplier) return;
                _supplier = value;
                OnPropertyChanged();
            }
        }

        private DateTime _createdAt;
        public DateTime createdAt
        {
            get
            { return _createdAt; }
            set
            {
                if (value == _createdAt) return;
                _createdAt = value;
                OnPropertyChanged();
            }
        }

        private DateTime _updatedAt;
        public DateTime updatedAt
        {
            get
            { return _updatedAt; }
            set
            {
                if (value == _updatedAt) return;
                _updatedAt = value;
                OnPropertyChanged();
            }
        }

        public virtual ObservableCollection<StoredProduct> products { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [ComplexType]
    
    public class ReciptType :  PurchaseRecipt
    {
        private bool _cash;
        public bool cash
        {
            get
            { return _cash; }
            set
            {
                if (value == _cash) return;
                _cash = value;
                OnPropertyChanged();
            }
        }

        private bool _postponed;
        public bool postponed
        {
            get
            { return _postponed; }
            set
            {
                if (value == _postponed) return;
                _postponed = value;
                OnPropertyChanged();
            }
        }

        private bool _cAndP;
        public bool cAndP
        {
            get
            { return _cAndP; }
            set
            {
                if (value == _cAndP) return;
                _cAndP = value;
                OnPropertyChanged();
            }
        }
    }
}
