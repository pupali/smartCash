
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

namespace SmartCasherProject.Entities.SuppliersManagmentEntities
{
    public partial class PurchaseRecipt : INotifyPropertyChanged
    {
        [Key]
        public long id
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
        public int reciptCost
        {
            get
            { return reciptCostSu; }
            set
            {
                if (value == reciptCostSu) return;
                reciptCostSu = value;
                OnPropertyChanged();
            }
        }

        // نوع قائمة الشراء
        public ReciptType type
        {
            get
            { return typeSu; }
            set
            {
                if (value == typeSu) return;
                typeSu = value;
                OnPropertyChanged();
            }
        }

        // كم المدفوع من قيمة القائمة نقديا
        public int? cashPayed
        {
            get
            { return cashPayedSu; }
            set
            {
                if (value == cashPayedSu) return;
                cashPayedSu = value;
                OnPropertyChanged();
            }
        }

        // كم المتبقي من قيمة القائمة لم يدفع
        public int? ammountLeft
        {
            get
            { return ammountLeftSu; }
            set
            {
                if (value == ammountLeftSu) return;
                ammountLeftSu = value;
                OnPropertyChanged();
            }
        }


        [ForeignKey("supplier")]
        public int supplierId
        {
            get
            { return supplierIdSu; }
            set
            {
                if (value == supplierIdSu) return;
                supplierIdSu = value;
                OnPropertyChanged();
            }
        }
      

        public DateTime createdAt
        {
            get
            { return createdAtSu; }
            set
            {
                if (value == createdAtSu) return;
                createdAtSu = value;
                OnPropertyChanged();
            }
        }
        public DateTime updatedAt
        {
            get
            { return updatedAtSu; }
            set
            {
                if (value == updatedAtSu) return;
                updatedAtSu = value;
                OnPropertyChanged();
            }
        }

        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    [ComplexType]
    public partial class ReciptType:INotifyPropertyChanged
    {
        public bool cash 
        {
            get
            { return cashSu; }
            set
            {
                if (value == cashSu) return;
                cashSu = value;
                OnPropertyChanged();
            }
        }
        public bool postponed
        {
            get
            { return postponedSu; }
            set
            {
                if (value == postponedSu) return;
                postponedSu = value;
                OnPropertyChanged();
            }
        }
        public bool cAndP
        {
            get
            { return cAndPSu; }
            set
            {
                if (value == cAndPSu) return;
                cAndPSu = value;
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
