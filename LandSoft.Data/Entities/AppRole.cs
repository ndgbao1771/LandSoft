using Microsoft.AspNetCore.Identity;

namespace LandSoft.Data.Entities
{
	public class AppRole : IdentityRole<int>
	{
		public string Description { get; set; }
	}
}
