using Teste.Data.Domain.Domain;
using Teste.Data.Domain.Interfaces.Controle;
using Teste.Data.Domain.Interfaces.Repositories.EF;

namespace Teste.Core.Core.Controllers
{
    public class WeatherForecastControle : IWeatherForecastControle
    {
        public readonly IWeatherForecastEFRepository _IWeatherForecastEFRepository;

        public WeatherForecastControle(IWeatherForecastEFRepository WeatherForecastEFRepository) {
            _IWeatherForecastEFRepository = WeatherForecastEFRepository;
        }

        public List<WeatherForecast> Get() => _IWeatherForecastEFRepository.GetAll() ?? new List<WeatherForecast>();

        public void Add(WeatherForecast model) {
            model.Id = Guid.NewGuid().ToString();
            _IWeatherForecastEFRepository.Add(model);
        }
    }
}
