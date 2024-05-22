using LandSoft.Data.Enums;
using LandSoft.Data.Interfaces;
using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class BillForRoomPerMonth : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public int DetailBillForRoomPerMonthId { get; set; }
        public List<DetailBillForRoomPerMonth> DetailBillForRoomPerMonths { get; set; }
    }
}
