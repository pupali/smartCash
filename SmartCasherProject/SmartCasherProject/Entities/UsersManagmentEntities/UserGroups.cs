using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.ObjectModel;


namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class UserGroup
    {
        [Key]
        public int id { get; set; }
        public string groupName { get; set; }
        public string groupDescription { get; set; }
        public virtual ObservableCollection<User> users { get; set; }
        public virtual ObservableCollection<GroupPermission> permissions { get; set; }

    }
}
