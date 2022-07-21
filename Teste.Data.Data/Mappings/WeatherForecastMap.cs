using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Data.Domain.Domain;

namespace Teste.Data.Data.Mappings
{
    public class WeatherForecastMap : IEntityTypeConfiguration<WeatherForecast>
    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder) {
            builder.ToTable("WeatherForecast");

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
