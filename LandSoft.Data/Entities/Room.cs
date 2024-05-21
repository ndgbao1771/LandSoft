using LandSoft.Data.Enums;
using LandSoft.Data.Interfaces;
using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
	public class Room : DomainEntity<int>, ISwitchable, IDateTracking
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Capacity { get; set; }
		public TypeRoom Genus { get; set; }
		public Status Status { get; set; }
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }
	}
}
