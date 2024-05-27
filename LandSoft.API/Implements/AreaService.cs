using AutoMapper;
using AutoMapper.QueryableExtensions;
using LandSoft.API.Interfaces;
using LandSoft.API.Models.Filters;
using LandSoft.API.Models.ViewModels;
using LandSoft.Data.Entities;
using LandSoft.Data.IRepositories;
using LandSoft.Infrastructure.Interfaces;

namespace LandSoft.API.Implements
{
	public class AreaService : IAreaService
	{
		private readonly IMapper _mapper;
		private readonly IAreaRepository _areaRepository;
		private readonly IUnitOfWork _unitOfWork;

		public AreaService(IMapper mapper, IAreaRepository areaRepository, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_areaRepository = areaRepository;
			_unitOfWork = unitOfWork;
		}

		public AreaViewModel Add(AreaViewModel model)
		{
			_areaRepository.Add(_mapper.Map<AreaViewModel, Area>(model));
			_unitOfWork.Commit();
			return model;
		}

		public void Delete(int id)
		{
			var result = _areaRepository.FindById(id);
			if (result == null)
			{
				return;
			}
			else
			{
				_areaRepository.Remove(id);
				_unitOfWork.Commit();
			}
		}

		public List<AreaViewModel> GetByFilter(AreaFilter filter)
		{
			var result = _areaRepository.GetQueryable();
			result = result.Where(x => string.IsNullOrEmpty(filter.Name) || x.Name == filter.Name)
						   .Where(x => !filter.Id.HasValue || x.Id == filter.Id);
			if (result == null)
			{
				return null;
			}
			else
			{
				return result.ProjectTo<AreaViewModel>(_mapper.ConfigurationProvider).ToList();
			}
		}

		public void Update(AreaViewModel model)
		{
			var result = _areaRepository.FindById(model.Id);
			if (result == null)
			{
				return;
			}
			else
			{
				_areaRepository.Update(_mapper.Map<AreaViewModel, Area>(model));
				_unitOfWork.Commit();
			}
		}
	}
}
