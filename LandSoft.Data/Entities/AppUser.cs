using LandSoft.Data.Enums;
using LandSoft.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace LandSoft.Data.Entities
{
	public class AppUser : IdentityUser<int>, ISwitchable, IDateTracking
	{
		public string Avatar { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public DateTime BirthDay { get; set; }
		public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

		public List<DetailBillForRoomPerMonth>? DetailBillForRoomPerMonths { get; set; }
		public List<DetailBillForService>? DetailBillForServices { get; set; }
		public List<RentalContract>? RentalContracts { get; set; }
    }
}
