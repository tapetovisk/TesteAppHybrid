using System.Net.Http.Json;
using Teste.Data.Domain.Domain;
using Teste.Data.Domain.Interfaces.Controle;

namespace Teste.Core.Service.Controllers
{
    public class WeatherForecastControle : IWeatherForecastControle
    {
        public readonly HttpClient _Http;

        public WeatherForecastControle(HttpClient http) {
            _Http = http;
        }

        public void Add(WeatherForecast model) {
            _Http.BaseAddress = new Uri("https://localhost:7277/");
            _Http.PostAsJsonAsync("WeatherForecast",model);
        }

        public List<WeatherForecast> Get() {
            _Http.BaseAddress = new Uri("https://localhost:7277/");
            return _Http.GetFromJsonAsync<List<WeatherForecast>>("WeatherForecast").Result 
                ?? new List<WeatherForecast>();
        }
    }
}
