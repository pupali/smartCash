using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace SmartCasherProject.Entities.PurchaseManagmentEntities
{
    public class Product : IEntityDates
    {
        [Key]
        public long productId { get; set; }

        public string productName { get; set; }
        public long barCode { get; set; }
        public string productImage { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; } 


        [ForeignKey("productCatagory")]
        public int? productCatagoryId { get; set; }
        public ProductCatagory productCatagory { get; set; }

        public ObservableCollection<ProductPrice> prices { get; set; }

        public ObservableCollection<ProductUnit> productUnits { get; set; }
    }

    public interface IEntityDates
    {
        DateTime createdAt { get; set; }
        DateTime updatedAt { get; set; }
    }
}
