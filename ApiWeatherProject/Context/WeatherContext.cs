using ApiWeatherProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWeatherProject.Context
{
	public class WeatherContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=EMIN\\SQLEXPRESS; initial catalog=ApiDb;integrated Security=true");
		}
        public DbSet<City> Cities { get; set; }
    }
}
