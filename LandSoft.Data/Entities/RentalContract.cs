using LandSoft.Data.Enums;
using LandSoft.Data.Interfaces;
using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class RentalContract : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string NameTenant { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal SecurityDeposit { get; set; }
        public string TermsAndConditions { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
