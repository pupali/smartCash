namespace SmartCasherProject.Entities
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using UsersManagmentEntities;

    public class SmartCashContext : DbContext
    {
        public SmartCashContext()
            : base("name=smartCashConnection")
        {


        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserGroup>()
                .HasMany(ug => ug.Users)
                .WithOptional(u => u.group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(u => u.permissions)
                .WithRequired(p => p.user)
                .WillCascadeOnDelete();

        }
        DbSet<UserPermission> UserPermissions { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserGroup> Groups {get; set;}

    }
}