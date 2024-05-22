using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
	public class ServiceConfiguration : IEntityTypeConfiguration<Service>
	{
		public void Configure(EntityTypeBuilder<Service> builder)
		{
			builder.ToTable("Services");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Price).HasColumnType("decimal(10,0)");
		}
	}
}
