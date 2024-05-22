using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class DetailBillForRoomPerMonth : DomainEntity<int>
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int BillForRoomPerMonthId { get; set; }
        public BillForRoomPerMonth BillForRoomPerMonth { get; set; }
    }
}
