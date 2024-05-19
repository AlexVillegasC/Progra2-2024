// MonitoreoClimatico.Architecture.Bussines.Model/WeatherModel.cs
namespace MonitoreoClimatico.Architecture.Bussines.Model
{
        public class WeatherModel
        {
            public string City { get; set; }
            public double Temperature { get; set; }
            public string Description { get; set; }
            public double Humidity { get; set; }
            public double WindSpeed { get; set; }
        }
}
