using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class Brand : DomainEntity<int>
    {
        public string Name { get; set; }

        public List<Device> Devices { get; set; }
    }
}
