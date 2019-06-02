using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.PurchaseManagmentEntities
{
    public class ProductPrice
    {
        [Key]
        public int id { get; set; }
        public int sellingPrice { get; set; }
        public int purchasePrice { get; set; }
        public DateTime startDate {get; set;}
        public DateTime endDate { get; set; }

        [ForeignKey("product")]
        public long productId { get; set; }
        public Product product { get; set; }
    }
}
