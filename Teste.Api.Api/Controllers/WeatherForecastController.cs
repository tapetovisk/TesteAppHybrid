using Microsoft.AspNetCore.Mvc;
using Teste.Data.Domain.Domain;
using Teste.Data.Domain.Interfaces.Controle;

namespace Teste.Api.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        public readonly IWeatherForecastControle _IWeatherForecastControle;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastControle weatherForecastControle) {
            _logger = logger;
            _IWeatherForecastControle = weatherForecastControle;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get() {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return _IWeatherForecastControle.Get();
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public IActionResult Post(WeatherForecast model) {
            _IWeatherForecastControle.Add(model);
            return Ok();
        }
    }
}