using AutoMapper;
using LandSoft.API.Models.ViewModels;
using LandSoft.Data.Entities;
using LandSoft.Data.EntityViewSQL;

namespace LandSoft.API.AutoMappers
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public DomainToViewModelMappingProfile()
		{
			CreateMap<Area, AreaViewModel>();
			CreateMap<AreaViewSQL, AreaViewModel>().ForMember(dest => dest.Id, otp => otp.MapFrom(x => x.Id))
												   .ForMember(dest => dest.Name, otp => otp.MapFrom(x => x.Name));
		}

	}
}
