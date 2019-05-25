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
    public class Module
    {
        [Key]
        public int id { get; set; }
        public string moduleName { get; set; }
        public string moduleDescription { get; set; }

        public ICollection<UserPermission> permissions { get; set; }

        public ICollection<GroupPermission> groupPermissions { get; set; }
    }
}
