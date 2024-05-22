using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Devices");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Brand).WithMany(x => x.Devices).HasForeignKey(x => x.BrandId);
            builder.HasOne(x => x.Room).WithMany(x => x.Devices).HasForeignKey(x => x.RoomId);
        }
    }
}
