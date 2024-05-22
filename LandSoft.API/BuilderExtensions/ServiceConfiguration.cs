using AutoMapper;
using LandSoft.API.AutoMappers;
using LandSoft.Data.EF;
using LandSoft.Data.EF.Data;
using LandSoft.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace LandSoft.API.BuilderExtensions
{
    public static class ServiceConfiguration
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(option => option.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<LSDbContext>()
                    .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // config Password
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 1;

                // Config Lockout - lock user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
            });

            services.AddScoped<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddScoped<RoleManager<AppRole>, RoleManager<AppRole>>();
            services.AddTransient<DbInitializer>();
        }

        public static void ConfigureMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped<IMapper>(am => new Mapper(am.GetRequiredService<AutoMapper.IConfigurationProvider>(), am.GetService));
        }
    }
}
