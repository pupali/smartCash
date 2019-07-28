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
   public class ProductCatagory :INotifyPropertyChanged
    {
        private int _catagoryId;
        [Key]
        public int catagoryId
        {
            get
            { return _catagoryId; }
            set
            {
                if (value == _catagoryId) return;
                _catagoryId = value;
                OnPropertyChanged();
            }
        }
        private string _catagoryName;
        public string catagoryName
        {
            get
            { return _catagoryName; }
            set
            {
                if (value == _catagoryName) return;
                _catagoryName = value;
                OnPropertyChanged();
            }
        }
        private string _catagoryImage;
        public string catagoryImage
        {
            get
            { return _catagoryImage; }
            set
            {
                if (value == _catagoryImage) return;
                _catagoryImage = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> products
        {
            get
            { return _products; }
            set
            {
                if (value == _products) return;
                _products = value;
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
