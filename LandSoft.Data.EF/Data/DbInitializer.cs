using LandSoft.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace LandSoft.Data.EF.Data
{
    public class DbInitializer
    {
        private readonly LSDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public DbInitializer(LSDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Staff",
                    NormalizedName = "Staff",
                    Description = "Staff"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Customer",
                    NormalizedName = "Customer",
                    Description = "Customer"
                });
            }
            if (!_userManager.Users.Any())
            {
                var a = await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FirstName = "Nguyen Van",
                    LastName = "A",
                    Email = "admin@gmail.com",
                    PhoneNumber = "0123456789",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = "Admin",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                }, "123456");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
