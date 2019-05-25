﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class UserGroup
    {
        [Key]
        public int id { get; set; }
        public string groupName { get; set; }
        public string groupDescription { get; set; }
        public ICollection<User> users { get; set; }
        public ICollection<GroupPermission> permissions { get; set; }

    }
}
