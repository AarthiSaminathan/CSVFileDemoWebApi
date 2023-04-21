using CSVFileDbDemo.Model;
using CSVFileDbDemo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSVFileDbDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        //[HttpPost("write-city-csv")]
        //public async Task<IActionResult> WriteEmployeeCSV([FromBody] List<Cities> cities)
        //{
        //    _cityService.WriteCSV<Cities>(cities);

        //    return Ok();
        //}


        //[HttpPost("read-cities-csv")]
        //public async Task<IActionResult> GetCitiesCSV([FromForm] IFormFileCollection file)
        //{
        //    var cities=_cityService.ReadCSV<Cities>(file[0].OpenReadStream());
        //    return Ok(cities);

        //}

        [HttpPost]
        public IActionResult LoadAllCities(Cities cities)
        {
             _cityService.LoadFile(cities);
            return Ok();
        }

        
    }
}
