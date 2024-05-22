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
            builder.ApplyConfiguration(new AreaConfiguration());
            builder.ApplyConfiguration(new BillConfiguration());
            builder.ApplyConfiguration(new BillForRoomPerMonthConfiguration());
            builder.ApplyConfiguration(new BillForServiceConfiguration());
            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new DetailBillForRoomPerMonthConfiguration());
            builder.ApplyConfiguration(new DetailBillForServiceConfiguration());
            builder.ApplyConfiguration(new DeviceConfiguration());
            builder.ApplyConfiguration(new InfoRegistrationOfTempAbsenceConfiguration());
            builder.ApplyConfiguration(new RentalContractConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());
			builder.ApplyConfiguration(new ServiceConfiguration());
		}
	}
}
