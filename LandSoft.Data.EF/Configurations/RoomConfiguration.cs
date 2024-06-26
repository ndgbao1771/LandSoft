﻿using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
	public class RoomConfiguration : IEntityTypeConfiguration<Room>
	{
		public void Configure(EntityTypeBuilder<Room> builder)
		{
			builder.ToTable("Rooms");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Price).HasColumnType("decimal(10,0)");
		}
	}
}
