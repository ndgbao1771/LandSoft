using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class Device : DomainEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
