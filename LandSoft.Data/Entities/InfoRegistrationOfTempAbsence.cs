using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class InfoRegistrationOfTempAbsence : DomainEntity<int>
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CitizenIdentificationCard { get; set; }
        public string AddressRegistrationOfTempAbsence { get; set; }
    }
}
