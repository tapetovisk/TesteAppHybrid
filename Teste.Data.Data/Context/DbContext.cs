using Microsoft.EntityFrameworkCore;
using Teste.Data.Data.Mappings;
using Teste.Data.Domain.Domain;

namespace Teste.Data.Data.Context
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options) {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new WeatherForecastMap());
        }

        public DbSet<WeatherForecast> WeatherForecast { get; set; }


    }
}
