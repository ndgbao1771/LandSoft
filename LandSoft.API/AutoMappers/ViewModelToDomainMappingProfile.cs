using AutoMapper;
using LandSoft.API.Models.ViewModels;
using LandSoft.Data.Entities;

namespace LandSoft.API.AutoMappers
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public ViewModelToDomainMappingProfile()
		{
			CreateMap<AreaViewModel, Area>().ConstructUsing(x => new Area(x.Id, x.Name));
		}
	}
}
