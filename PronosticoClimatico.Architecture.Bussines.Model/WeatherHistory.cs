// MonitoreoClimatico.Architecture.Bussines.Model/WeatherHistory.cs
namespace MonitoreoClimatico.Architecture.Bussines.Model
{
    public class WeatherHistory
    {
        public int Id { get; set; }
        public string City { get; set; }
        public double Temperature { get; set; }
        public string Description { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public DateTime Date { get; set; }
    }
}
