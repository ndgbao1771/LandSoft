using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class DetailBillForServiceConfiguration : IEntityTypeConfiguration<DetailBillForService>
    {
        public void Configure(EntityTypeBuilder<DetailBillForService> builder)
        {
            builder.ToTable("DetailBillForServices");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.AppUser).WithMany(x => x.DetailBillForServices).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Service).WithMany(x => x.DetailBillForServices).HasForeignKey(x => x.ServiceId);
        }
    }
}
