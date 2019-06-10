using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCasherProject.Entities.ProductManagmentEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SmartCasherProject.Entities.SuppliersManagmentEntities;

namespace SmartCasherProject.Entities.StorageManagmentEntities
{
    public class StoredProduct
    {
        [Key]
        public long id { get; set; }

        [ForeignKey("product")]
        public long productId { get; set; }
        public Product product { get; set; }

        [ForeignKey("unit")]
        public int? unitId { get; set; }
        public ProductUnit unit {get; set;}

        [ForeignKey("supplier")]
        public int supplierId { get; set; }
        public Supplier supplier { get; set; }

        [ForeignKey("storage")]
        public int? storageId { get; set; }
        public Storage storage { get; set; }

        [ForeignKey("recipt")]
        public long? reciptId { get; set; }
        public PurchaseRecipt recipt { get; set; }
    }
}
