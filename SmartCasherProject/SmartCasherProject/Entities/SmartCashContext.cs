using System;
using System.Data.Entity;
using System.Linq;
using SmartCasherProject.Entities.UsersManagmentEntities;
using SmartCasherProject.Entities.ProductManagmentEntities;
using SmartCasherProject.Entities.StorageManagmentEntities;
using System.Threading.Tasks;
using SmartCasherProject.Entities.SuppliersManagmentEntities;

namespace SmartCasherProject.Entities { 
    public class SmartCashContext : DbContext
    {
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<GroupPermission> GroupPermissions { get; set; }
        public DbSet<UserGroup> Groups { get; set; }
        public DbSet<Product> Products {get; set;}
        public DbSet<ProductCatagory> ProductCatagories {get; set;}
        public DbSet<ProductUnit> ProductUnites { get; set; }
        public DbSet<Storage> Storages {get; set;} 
        public DbSet<StoredProduct> StoredProducts {get; set;}
        public DbSet<Supplier> Suppliers {get; set;}
        public DbSet<PurchaseRecipt> Recipts {get; set;}

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


            modelBuilder.Entity<Product>()
                .HasMany(p => p.productUnits)
                .WithRequired(pu => pu.product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<StoredProduct>()
                .HasOptional(p => p.storage)
                .WithMany(s => s.products)
                .HasForeignKey(s => s.storageId);

            modelBuilder.Entity<StoredProduct>()
                .HasOptional(p => p.recipt)
                .WithMany(r => r.products)
                .HasForeignKey(p => p.reciptId);
                
        }

        public override int SaveChanges()
        {
            BeforeSave();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync()
        {
            BeforeSave();
            return base.SaveChangesAsync();
        }

        private void BeforeSave()
        {
            var entries = ChangeTracker.Entries();
            foreach(var entry in entries)
            {
                if( entry.Entity is IEntityDates entity)
                switch (entry.State)
                {
                    case EntityState.Added:
                            entity.createdAt = DateTime.Now;
                            entity.updatedAt = DateTime.Now;
                            break;
                    case EntityState.Modified:
                            entity.updatedAt = DateTime.Now;
                            break;
                }
            }
        }
    }
}