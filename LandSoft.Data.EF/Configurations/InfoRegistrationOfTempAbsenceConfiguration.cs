using LandSoft.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandSoft.Data.EF.Configurations
{
    public class InfoRegistrationOfTempAbsenceConfiguration : IEntityTypeConfiguration<InfoRegistrationOfTempAbsence>
    {
        public void Configure(EntityTypeBuilder<InfoRegistrationOfTempAbsence> builder)
        {
            builder.ToTable("InfoRegistrationOfTempAbsences");
            builder.HasKey(x => x.Id);
        }
    }
}
