
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.ProductManagmentEntities
{
    public partial class ProductUnit : INotifyPropertyChanged
    {
        [Key]
        public int id
        {
            get
            { return idP; }
            set
            {
                if (value == idP) return;
                idP = value;
                OnPropertyChanged();
            }
        }

        public string unitName
        {
            get
            { return unitNameP; }
            set
            {
                if (value == unitNameP) return;
                unitNameP = value;
                OnPropertyChanged();
            }
        }
        public int unitAmount
        {
            get
            { return unitAmountP; }
            set
            {
                if (value == unitAmountP) return;
                unitAmountP = value;
                OnPropertyChanged();
            }
        }
        public int unitPrice
        {
            get
            { return unitPriceP; }
            set
            {
                if (value == unitPriceP) return;
                unitPriceP = value;
                OnPropertyChanged();
            }
        }
        public int unitAvgPrice
        {
            get
            { return unitAvgPriceP; }
            set
            {
                if (value == unitAvgPriceP) return;
                unitAvgPriceP = value;
                OnPropertyChanged();
            }
        }
        public int unitSellingPrice
        {
            get
            { return unitSellingPriceP; }
            set
            {
                if (value == unitSellingPriceP) return;
                unitSellingPriceP = value;
                OnPropertyChanged();
            }
        }
        public bool defaultUnit
        {
            get
            { return defaultUnitP; }
            set
            {
                if (value == defaultUnitP) return;
                defaultUnitP = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("product")]
        public long productid
        {
            get
            { return productidP; }
            set
            {
                if (value == productidP) return;
                productidP = value;
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
