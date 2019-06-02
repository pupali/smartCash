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
   public class ProductCatagory
    {
        [Key]
        public int catagoryId {get; set;}
        public string catagoryName { get; set; }
        public string catagoryImage { get; set; }

        public ObservableCollection<Product> products { get; set; }
    }
}
