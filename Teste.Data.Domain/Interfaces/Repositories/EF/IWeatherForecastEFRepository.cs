using Teste.Data.Domain.Domain;
using Teste.Data.Domain.Interfaces.Repositories.Common;

namespace Teste.Data.Domain.Interfaces.Repositories.EF
{
    public interface IWeatherForecastEFRepository : IRepositoryBase<WeatherForecast>
    {
    }
}
