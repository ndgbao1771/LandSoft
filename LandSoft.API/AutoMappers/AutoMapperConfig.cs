﻿using AutoMapper;

namespace LandSoft.API.AutoMappers
{
	public class AutoMapperConfig
	{
		public static MapperConfiguration RegisterMapping()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new DomainToViewModelMappingProfile());
				cfg.AddProfile(new ViewModelToDomainMappingProfile());
			});
		}
	}
}
