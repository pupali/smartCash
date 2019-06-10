using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using SmartCasherProject.Entities.ProductManagmentEntities;


namespace SmartCasherProject.Entities.UsersManagmentEntities
    
{
    
    public class User : IEntityDates
    {
        [Key]
        public long id { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public DateTime? deletedAt { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName{get; set;}
        public string address{get; set;}
        public string description {get; set;}
        public string imageUrl{get; set;}
        public string password { get; set; }
        public bool isAdmin { get; set; }
        
      
        public ObservableCollection<UserPermission> permissions { get; set; }


        [ForeignKey("group")]
        public int? groupId { get; set; }
        public UserGroup group { get; set; }

    }
}
