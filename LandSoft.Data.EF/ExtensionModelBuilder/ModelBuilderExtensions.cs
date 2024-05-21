using LandSoft.Data.EF.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LandSoft.Data.EF.ExtensionModelBuilder
{
	public static class ModelBuilderExtensions
	{
		public static void ApplyAllConfigurations(this ModelBuilder builder)
		{
			builder.ApplyConfiguration(new AppUserConfiguration());
			builder.ApplyConfiguration(new AppRoleConfiguration());
			builder.ApplyConfiguration(new BillConfiguration());
			builder.ApplyConfiguration(new RoomConfiguration());
			builder.ApplyConfiguration(new ServiceConfiguration());
		}
	}
}
