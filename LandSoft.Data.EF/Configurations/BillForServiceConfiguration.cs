using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class BillForServiceConfiguration : IEntityTypeConfiguration<BillForService>
    {
        public void Configure(EntityTypeBuilder<BillForService> builder)
        {
            builder.ToTable("BillForServices");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).HasColumnType("decimal(10,0)");
        }
    }
}
