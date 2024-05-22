using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class DetailBillForService : DomainEntity<int>
    {
        public int BillForServiceId { get; set; }
        public BillForService BillForService { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
