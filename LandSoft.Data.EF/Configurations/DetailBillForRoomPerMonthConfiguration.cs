using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class DetailBillForRoomPerMonthConfiguration : IEntityTypeConfiguration<DetailBillForRoomPerMonth>
    {
        public void Configure(EntityTypeBuilder<DetailBillForRoomPerMonth> builder)
        {
            builder.ToTable("DetailBillForRoomPerMonths");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Room).WithMany(x => x.DetailBillForRoomPerMonths).HasForeignKey(x => x.RoomId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.DetailBillForRoomPerMonths).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.BillForRoomPerMonth).WithMany(x => x.DetailBillForRoomPerMonths).HasForeignKey(x => x.BillForRoomPerMonthId);
        }
    }
}
