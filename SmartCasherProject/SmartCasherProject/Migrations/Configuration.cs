namespace SmartCasherProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SmartCasherProject.Entities.UsersManagmentEntities;
    using SmartCasherProject.Entities;
    using SmartCasherProject.Entities.PurchaseManagmentEntities;

    internal sealed class Configuration : DbMigrationsConfiguration<SmartCashContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SmartCashContext context)
        {
            context.Users.AddOrUpdate(new User()
            {
                firstName = "ali",
                lastName = "ali",
                isAdmin = true,
                password = "password"

            });

            context.Products.AddOrUpdate(new Product()
            {
                productName = "product1",

            });

            //context.Users.AddOrUpdate(new User()
            //{
            //    nickName = "name",
            //    lastName = "name2",
            //    firstName = "name3",
            //    address = "address",
            //    description = "description jkfhjkw",
            //    password = "password",
            //    createdAt = DateTime.Now,
            //    updatedAt = DateTime.Now,
            //    deletedAt = DateTime.Now,
            //    group = new UserGroup() { groupDescription = "desc", groupName = "test" }
            //});
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
