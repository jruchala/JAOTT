namespace JAOTT.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

      
       internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }
            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                roleManager.Create(new IdentityRole { Name = "Moderator" });
            }
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "bs429455@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "JohnnyEh",
                    Email = "bs429455@gmail.com",

                    
                }, "");
            }
            if (!context.Users.Any(u => u.Email == "jruchala@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "James",
                    Email = "jruchala@gmail.com",

                    
                }, "");
            }

            var userId = userManager.FindByEmail("bs429455@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");
            var user_Id = userManager.FindByEmail("jruchala@gmail.com").Id;
            userManager.AddToRole(user_Id, "Moderator");
        }
    }
}