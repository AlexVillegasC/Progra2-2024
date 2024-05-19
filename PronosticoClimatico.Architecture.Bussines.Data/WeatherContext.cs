// MonitoreoClimatico.Architecture.Bussines.Data/WeatherContext.cs
using Microsoft.EntityFrameworkCore;
using MonitoreoClimatico.Architecture.Bussines.Model;
using System.Collections.Generic;

namespace MonitoreoClimatico.Architecture.Bussines.Data
{
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherHistory> WeatherHistories { get; set; }

        public WeatherContext(DbContextOptions<WeatherContext> options)
            : base(options)
        {
        }
    }
}