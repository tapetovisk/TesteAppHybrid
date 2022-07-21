using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Teste.Data.Data.Context;
using Teste.Data.Data.Repositories;
using Teste.Data.Domain.Interfaces.Repositories.EF;

namespace Teste.Data.IaC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services) {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            var  DbPath = Path.Join(path, "Teste.db");

            services.AddDbContext<BDContext>(option => option.UseSqlite($"Data Source={DbPath}"));
            services.AddScoped<BDContext>();

            services.AddScoped<IWeatherForecastEFRepository, WeatherForecastEFRepository>();
        }
    }
}
