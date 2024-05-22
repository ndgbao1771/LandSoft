using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class Area : DomainEntity<int>
    {
        public string Name { get; set; }
        public List<Room>? Rooms { get; set; }
    }
}
