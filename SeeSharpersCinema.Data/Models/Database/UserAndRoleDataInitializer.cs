using Microsoft.AspNetCore.Identity;

namespace SeeSharpersCinema.Models.Database
{
    public static class UserAndRoleDataInitializer
    {
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Backoffice").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Backoffice";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Manager").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Manager";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Cashier").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Cashier";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Subscriber").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Subscriber";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Member").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Member";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("admin@sscinema.nl").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin";
                user.Email = "admin@sscinema.nl";

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            if (userManager.FindByEmailAsync("backoffice@sscinema.nl").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "backoffice";
                user.Email = "backoffice@sscinema.nl";

                IdentityResult result = userManager.CreateAsync(user, "backoffice").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Backoffice").Wait();
                }
            }

            if (userManager.FindByEmailAsync("manager@sscinema.nl").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "manager";
                user.Email = "manager@sscinema.nl";

                IdentityResult result = userManager.CreateAsync(user, "manager").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }

            if (userManager.FindByEmailAsync("cashier@sscinema.nl").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "cashier";
                user.Email = "cashier@sscinema.nl";

                IdentityResult result = userManager.CreateAsync(user, "cashier").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Cashier").Wait();
                }
            }

            if (userManager.FindByEmailAsync("subscriber@sscinema.nl").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "subscriber";
                user.Email = "subscriber@sscinema.nl";

                IdentityResult result = userManager.CreateAsync(user, "subscriber").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Subscriber").Wait();
                }
            }

            if (userManager.FindByEmailAsync("member@sscinema.nl").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "member";
                user.Email = "member@sscinema.nl";

                IdentityResult result = userManager.CreateAsync(user, "member").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Member").Wait();
                }
            }
        }
    }
}
