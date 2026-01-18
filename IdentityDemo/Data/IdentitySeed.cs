using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Data
{
    public class IdentitySeed
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            const string adminRole = "Admin";
            const string adminEmail = "admin@demo.se";
            var roleExists = await roleManager.RoleExistsAsync(adminRole);
            if (!roleExists)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser is null)
            {
                return;
            }
            var isInRole = await userManager.IsInRoleAsync(adminUser, adminRole);
            if (!isInRole)
            {
                await userManager.AddToRoleAsync(adminUser, adminRole);
            }
        }
    }
}
