using SmartCasherProject.Entities.ProductManagmentEntities;
using SmartCasherProject.Entities.SuppliersManagmentEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.StorageManagmentEntities
{
    public partial class StoredProduct : INotifyPropertyChanged
    {
        [Key]
        public long id
        {
            get
            { return idS; }
            set
            {
                if (value == idS) return;
                idS = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("product")]
        public long productId
        {
            get
            { return productIdS; }
            set
            {
                if (value == productIdS) return;
                productIdS = value;
                OnPropertyChanged();
            }
        }
        

        [ForeignKey("unit")]
        public int? unitId
        {
            get
            { return unitIdS; }
            set
            {
                if (value == unitIdS) return;
                unitIdS = value;
                OnPropertyChanged();
            }
        }
       

        [ForeignKey("supplier")]
        public int supplierId
        {
            get
            { return supplierIdS; }
            set
            {
                if (value == supplierIdS) return;
                supplierIdS = value;
                OnPropertyChanged();
            }
        }
        
 
        [ForeignKey("storage")]
        public int? storageId
        {
            get
            { return storageIdS; }
            set
            {
                if (value == storageIdS) return;
                storageIdS = value;
                OnPropertyChanged();
            }
        }
       

        [ForeignKey("recipt")]
        public long? reciptId
        {
            get
            { return reciptIdS; }
            set
            {
                if (value == reciptIdS) return;
                reciptIdS = value;
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
