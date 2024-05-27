using LandSoft.API.Interfaces;
using LandSoft.API.Models.Filters;
using LandSoft.API.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LandSoft.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AreaController : ControllerBase
	{
		private readonly IAreaService _areaService;

		public AreaController(IAreaService areaService)
		{
			_areaService = areaService;
		}

		// GET: api/<AreaController>
		[HttpGet]
		public IActionResult Get([FromQuery] AreaFilter filter)
		{
			var datas = _areaService.GetByFilter(filter);
			return Ok(datas);
		}

		// GET api/<AreaController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<AreaController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<AreaController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<AreaController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
