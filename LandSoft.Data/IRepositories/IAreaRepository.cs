using LandSoft.Data.Entities;
using LandSoft.Data.EntityViewSQL;
using LandSoft.Infrastructure.Interfaces;

namespace LandSoft.Data.IRepositories
{
	public interface IAreaRepository : IRepository<Area, int>
	{
		IQueryable<AreaViewSQL> GetQueryable();
	}
}
