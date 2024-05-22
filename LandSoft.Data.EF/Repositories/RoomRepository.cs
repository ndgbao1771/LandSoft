using LandSoft.Data.Entities;
using LandSoft.Data.IRepositories;

namespace LandSoft.Data.EF.Repositories
{
    public class RoomRepository : EFRepository<Room, int>, IRoomRepository
    {
        public RoomRepository(LSDbContext context) : base(context)
        {
        }
    }
}
