using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCasherProject.Entities.ProductManagmentEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SmartCasherProject.Entities.SuppliersManagmentEntities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.StorageManagmentEntities
{
    public class StoredProduct:INotifyPropertyChanged
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

        private long _productId;
        [ForeignKey("product")]
        public long productId
        {
            get
            { return _productId; }
            set
            {
                if (value == _productId) return;
                _productId = value;
                OnPropertyChanged();
            }
        }

        private Product _product;
        public Product product
        {
            get
            { return _product; }
            set
            {
                if (value == _product) return;
                _product = value;
                OnPropertyChanged();
            }
        }

        public int? _unitId;
        [ForeignKey("unit")]
        public int? unitId
        {
            get
            { return _unitId; }
            set
            {
                if (value == _unitId) return;
                _unitId = value;
                OnPropertyChanged();
            }
        }

        private ProductUnit _unit;
        public ProductUnit unit
        {
            get
            { return _unit; }
            set
            {
                if (value == _unit) return;
                _unit = value;
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

        private int? _storageId;
        [ForeignKey("storage")]
        public int? storageId
        {
            get
            { return _storageId; }
            set
            {
                if (value == _storageId) return;
                _storageId = value;
                OnPropertyChanged();
            }
        }

        private Storage _storage;
        public Storage storage
        {
            get
            { return _storage; }
            set
            {
                if (value == _storage) return;
                _storage = value;
                OnPropertyChanged();
            }
        }

        private long? _reciptId;
        [ForeignKey("recipt")]
        public long? reciptId
        {
            get
            { return _reciptId; }
            set
            {
                if (value == _reciptId) return;
                _reciptId = value;
                OnPropertyChanged();
            }
        }

        private PurchaseRecipt _recipt;
        public PurchaseRecipt recipt
        {
            get
            { return _recipt; }
            set
            {
                if (value == _recipt) return;
                _recipt = value;
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
