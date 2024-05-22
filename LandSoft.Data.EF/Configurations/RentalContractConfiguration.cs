using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class RentalContractConfiguration : IEntityTypeConfiguration<RentalContract>
    {
        public void Configure(EntityTypeBuilder<RentalContract> builder)
        {
            builder.ToTable("RentalContracts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SecurityDeposit).HasColumnType("decimal(10,0)");
            builder.HasOne(x => x.AppUser).WithMany(x => x.RentalContracts).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.Room).WithMany(x => x.RentalContracts).HasForeignKey(x => x.RoomId);
        }
    }
}
