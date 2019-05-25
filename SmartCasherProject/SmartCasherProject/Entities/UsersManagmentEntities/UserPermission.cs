using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    class UserPermission
    {
        [Key]
        public long id { get; set; }
        public bool delete {get; set;}
        public bool create {get; set;}
        public bool edit {get; set;}
        public bool read {get; set;}

        [ForeignKey("user")]
        public long userId { get; set; }
        public User user { get; set; }
    }
}
