using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.ProductManagmentEntities
{
    public partial class Product : INotifyPropertyChanged
    {
        [Key]
        public long productId
        {
            get
            { return productIdP; }
            set
            {
                if (value == productIdP) return;
                productIdP = value;
                OnPropertyChanged();
            }
        }


        public string productName
        {
            get
            { return productNameP; }
            set
            {
                if (value == productNameP) return;
                productNameP = value;
                OnPropertyChanged();
            }
        }


        public long barCode
        {
            get
            { return barCodeP; }
            set
            {
                if (value == barCodeP) return;
                barCodeP = value;
                OnPropertyChanged();
            }
        }


        public string productImage
        {
            get
            { return productImageP; }
            set
            {
                if (value == productImageP) return;
                productImageP = value;
                OnPropertyChanged();
            }
        }


        public int currentPrice
        {
            get
            { return currentPriceP; }
            set
            {
                if (value == currentPriceP) return;
                currentPriceP = value;
                OnPropertyChanged();
            }
        }


        public DateTime createdAt
        {
            get
            { return createdAtP; }
            set
            {
                if (value == createdAtP) return;
                createdAtP = value;
                OnPropertyChanged();
            }
        }

        public DateTime updatedAt
        {
            get
            { return updatedAtP; }
            set
            {
                if (value == updatedAtP) return;
                updatedAtP = value;
                OnPropertyChanged();
            }
        }



        [ForeignKey("productCatagory")]
        public int? productCatagoryId
        {
            get
            { return productCatagoryIdP; }
            set
            {
                if (value == productCatagoryIdP) return;
                productCatagoryIdP = value;
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
