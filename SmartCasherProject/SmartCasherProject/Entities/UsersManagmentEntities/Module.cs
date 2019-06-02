using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class Module
    {
        [Key]
        public int id { get; set; }
        public string moduleName { get; set; }
        public string moduleDescription { get; set; }

        public ObservableCollection<UserPermission> permissions { get; set; }
              
        public ObservableCollection<GroupPermission> groupPermissions { get; set; }
    }
}
