using LandSoft.Data.Entities;
using LandSoft.Data.EntityViewSQL;
using LandSoft.Data.IRepositories;

namespace LandSoft.Data.EF.Repositories
{
	public class AreaRepository : EFRepository<Area, int>, IAreaRepository
	{
		private readonly LSDbContext _context;
		public AreaRepository(LSDbContext context) : base(context)
		{
			_context = context;
		}

		public IQueryable<AreaViewSQL> GetQueryable()
		{
			return _context.areaViewSQLs.AsQueryable();
		}
	}
}
