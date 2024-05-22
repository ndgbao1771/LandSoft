using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class BillForRoomPerMonthConfiguration : IEntityTypeConfiguration<BillForRoomPerMonth>
    {
        public void Configure(EntityTypeBuilder<BillForRoomPerMonth> builder)
        {
            builder.ToTable("BillForRoomPerMonths");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).HasColumnType("decimal(10,0)");
        }
    }
}
