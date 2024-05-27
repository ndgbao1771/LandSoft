using LandSoft.API.Models.Filters;
using LandSoft.API.Models.ViewModels;

namespace LandSoft.API.Interfaces
{
	public interface IAreaService
	{
		List<AreaViewModel> GetByFilter (AreaFilter filter);
		AreaViewModel Add(AreaViewModel model);
		void Update(AreaViewModel model);
		void Delete(int id);
	}
}
