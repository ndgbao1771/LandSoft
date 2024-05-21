using LandSoft.Data.EF.ExtensionModelBuilder;
using LandSoft.Data.Entities;
using LandSoft.Data.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LandSoft.Data.EF
{
	public class LSDbContext : IdentityDbContext<AppUser, AppRole, int>
	{
		public LSDbContext(DbContextOptions options) : base(options)
		{
		}

		#region Register DbSet
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Service> Services { get; set; }
		#endregion Register DbSet

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyAllConfigurations();

			base.OnModelCreating(builder);

			foreach (var entityType in builder.Model.GetEntityTypes())
			{
				var tableName = entityType.GetTableName();
				if (tableName.StartsWith("AspNet"))
				{
					entityType.SetTableName(tableName.Substring(6));
				}
			}
		}

		public override int SaveChanges()
		{
			var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

			foreach (EntityEntry item in modified)
			{
				var changedOrAddedItem = item.Entity as IDateTracking;
				if (changedOrAddedItem != null)
				{
					if (item.State == EntityState.Added)
					{
						changedOrAddedItem.CreatedAt = DateTime.Now;
					}
					changedOrAddedItem.UpdatedAt = DateTime.Now;
				}
			}
			return base.SaveChanges();
		}
	}
}
