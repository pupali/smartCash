using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.ProductManagmentEntities
{
    public class Product : IEntityDates , INotifyPropertyChanged
    {
        private long _productId;
        [Key]
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

        private string _productName;
        public string productName
        {
            get
            { return _productName; }
            set
            {
                if (value == _productName) return;
                _productName = value;
                OnPropertyChanged();
            }
        }
        private long _barCode;
        public long barCode
        {
            get
            { return _barCode; }
            set
            {
                if (value == _barCode) return;
                _barCode = value;
                OnPropertyChanged();
            }
        }
        private string _productImage;
        public string productImage
        {
            get
            { return _productImage; }
            set
            {
                if (value == _productImage) return;
                _productImage = value;
                OnPropertyChanged();
            }
        }
        private int _currentPrice;
        public int currentPrice
        {
            get
            { return _currentPrice; }
            set
            {
                if (value == _currentPrice) return;
                _currentPrice = value;
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

        private int? _productCatagoryId;
        [ForeignKey("productCatagory")]
        public int? productCatagoryId
        {
            get
            { return _productCatagoryId; }
            set
            {
                if (value == _productCatagoryId) return;
                _productCatagoryId = value;
                OnPropertyChanged();
            }
        }
        private ProductCatagory _productCatagory;
        public ProductCatagory productCatagory
        {
            get
            { return _productCatagory; }
            set
            {
                if (value == _productCatagory) return;
                _productCatagory = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<ProductUnit> _productUnits;
        public ObservableCollection<ProductUnit> productUnits
        {
            get
            { return _productUnits; }
            set
            {
                if (value == _productUnits) return;
                _productUnits = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public interface IEntityDates
    {
        DateTime createdAt { get; set; }
        DateTime updatedAt { get; set; }
    }
}
