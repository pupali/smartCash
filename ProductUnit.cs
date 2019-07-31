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
    public class ProductUnit:INotifyPropertyChanged
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

        private string _unitName;
        public string unitName
        {
            get
            { return _unitName; }
            set
            {
                if (value == _unitName) return;
                _unitName = value;
                OnPropertyChanged();
            }
        }

        private int _unitAmount;
        public int unitAmount
        {
            get
            { return _unitAmount; }
            set
            {
                if (value == _unitAmount) return;
                _unitAmount = value;
                OnPropertyChanged();
            }
        }

        private int _unitPrice;
        public int unitPrice
        {
            get
            { return _unitPrice; }
            set
            {
                if (value == _unitPrice) return;
                _unitPrice = value;
                OnPropertyChanged();
            }
        }

        private int _unitAvgPrice;
        public int unitAvgPrice
        {
            get
            { return _unitAvgPrice; }
            set
            {
                if (value == _unitAvgPrice) return;
                _unitAvgPrice = value;
                OnPropertyChanged();
            }
        }

        private int _unitSellingPrice;
        public int unitSellingPrice
        {
            get
            { return _unitAvgPrice; }
            set
            {
                if (value == _unitAvgPrice) return;
                _unitAvgPrice = value;
                OnPropertyChanged();
            }
        }

        private bool _defaultUnit;
        public bool defaultUnit
        {
            get
            { return _defaultUnit; }
            set
            {
                if (value == _defaultUnit) return;
                _defaultUnit = value;
                OnPropertyChanged();
            }
        }

        private long _productid;
        [ForeignKey("product")]
        public long productid
        {
            get
            { return _productid; }
            set
            {
                if (value == _productid) return;
                _productid = value;
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

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
