using LandSoft.Data.Enums;
using LandSoft.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace LandSoft.Data.Entities
{
	public class AppUser : IdentityUser<int>, ISwitchable
	{
		public string Avatar { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public DateTime BirthDay { get; set; }
		public Status Status { get; set; }
	}
}
