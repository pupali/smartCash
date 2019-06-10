using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SmartCasherProject.Entities.SuppliersManagmentEntities
{
    public class Supplier
    {
        [Key]
        public int id { get; set; }
        public string suplierName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
    }
}
