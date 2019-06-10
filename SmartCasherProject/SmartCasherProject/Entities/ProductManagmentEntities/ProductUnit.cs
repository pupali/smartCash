using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;


namespace SmartCasherProject.Entities.ProductManagmentEntities
{
    public class ProductUnit
    {
        [Key]
        public int id { get; set; }

        public string unitName { get; set; }
        public int unitAmount { get; set; }
        public int unitPrice { get; set; }
        public int unitAvgPrice { get; set; }
        public int unitSellingPrice { get; set; }
        public bool defaultUnit { get; set; }

        [ForeignKey("product")]
        public long productid { get; set; }
        public Product product { get; set; }

    }
}
