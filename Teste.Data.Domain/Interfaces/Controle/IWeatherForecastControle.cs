using Teste.Data.Domain.Domain;

namespace Teste.Data.Domain.Interfaces.Controle
{
    public interface IWeatherForecastControle
    {
        List<WeatherForecast> Get();
        void Add(WeatherForecast model);
    }
}
