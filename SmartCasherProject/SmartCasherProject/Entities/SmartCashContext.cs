using System;
using System.Data.Entity;
using System.Linq;
using SmartCasherProject.Entities.UsersManagmentEntities;

namespace SmartCasherProject.Entities { 
    public class SmartCashContext : DbContext
    {
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> Groups { get; set; }

        public SmartCashContext()
            : base("name=smartCashConnection")
        {


        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserGroup>()
                .HasMany(ug => ug.users)
                .WithOptional(u => u.group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(u => u.permissions)
                .WithRequired(p => p.user)
                .WillCascadeOnDelete();
        }
       

    }
}