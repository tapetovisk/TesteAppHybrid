using Teste.Data.Data.Context;
using Teste.Data.Data.Repositories.Common;
using Teste.Data.Domain.Domain;
using Teste.Data.Domain.Interfaces.Repositories.EF;

namespace Teste.Data.Data.Repositories
{
    public class WeatherForecastEFRepository : EFRepositoryBase<WeatherForecast>, IWeatherForecastEFRepository
    {
        public WeatherForecastEFRepository(BDContext BD) : base(BD) { }
    }
}
