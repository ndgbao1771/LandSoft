using LandSoft.Data.Enums;
using LandSoft.Data.Interfaces;
using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
	public class BillForService : DomainEntity<int>, ISwitchable, IDateTracking
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public Status Status { get; set; }
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }

		public List<DetailBillForService> DetailBillForServices { get; set; }
	}
}
