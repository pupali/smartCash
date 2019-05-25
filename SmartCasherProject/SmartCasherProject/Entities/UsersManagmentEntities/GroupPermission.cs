using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class GroupPermission
    {
        [Key]
        public long id { get; set; }
        public bool delete { get; set; }
        public bool create { get; set; }
        public bool edit { get; set; }
        public bool read { get; set; }

        [ForeignKey("group")]
        public int groupId { get; set; }
        public UserGroup group { get; set; }

        [ForeignKey("module")]
        public int moduleId { get; set; }
        public Module module { get; set; }
    }
}
