using System.ComponentModel.DataAnnotations;

namespace Teste.Data.Domain.Domain
{
    public class WeatherForecast
    {
        [Key]
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
