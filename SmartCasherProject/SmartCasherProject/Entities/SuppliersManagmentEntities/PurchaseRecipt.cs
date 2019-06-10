using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCasherProject.Entities.ProductManagmentEntities;
using SmartCasherProject.Entities.StorageManagmentEntities;

namespace SmartCasherProject.Entities.SuppliersManagmentEntities
{
    public class PurchaseRecipt : IEntityDates
    {
        [Key]
        public long id { get; set; }
        public int reciptCost { get; set; }

        // نوع قائمة الشراء
        public ReciptType type { get; set; }

        // كم المدفوع من قيمة القائمة نقديا
        public int? cashPayed { get; set; }

        // كم المتبقي من قيمة القائمة لم يدفع
        public int? ammountLeft { get; set; }


        [ForeignKey("supplier")]
        public int supplierId { get; set; }
        public Supplier supplier { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public virtual ObservableCollection<StoredProduct> products { get; set; } 
    }

    [ComplexType]
    public class ReciptType
    {
        public bool cash { get; set; }
        public bool postponed { get; set; }
        public bool cAndP { get; set; }
    }
}
