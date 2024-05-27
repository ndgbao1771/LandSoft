using LandSoft.Infrastructure.SharedKernel;

namespace LandSoft.Data.Entities
{
    public class Area : DomainEntity<int>
    {
		public Area() { }
		public Area(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public string Name { get; set; }
        public List<Room>? Rooms { get; set; }
    }
}
