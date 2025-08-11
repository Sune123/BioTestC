using BioTest.Code;
using Microsoft.AspNetCore.Mvc;

namespace BioTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpPost("dataInfo")]
        public async Task<IActionResult> GetData([FromBody] string url)
        {
            var x = new MyClass();
            return Ok(await x.GetExternalData(url));
        }

        [HttpGet("weather")]
        public async Task<string> GetWether(decimal t)
        {
            return new WeatherForecast().GetWeatherInfo((int)t);
        }
    }
}