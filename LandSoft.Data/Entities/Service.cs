using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
	public class Service : DomainEntity<int>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		public List<DetailBillForService> DetailBillForServices { get; set; }
	}
}
