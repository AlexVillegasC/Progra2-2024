// MonitoreoClimatico.Architecture.Bussines/WeatherService.cs
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonitoreoClimatico.Architecture.Bussines.Data;
using MonitoreoClimatico.Architecture.Bussines.Model;
using Newtonsoft.Json.Linq;

namespace MonitoreoClimatico.Architecture.Bussines
{
    public class WeatherService
    {
        private readonly string _apiKey = "9bc3f1962d75c941beda3347b475a681";
        private readonly HttpClient _httpClient;
        private readonly WeatherContext _context;

        public WeatherService(WeatherContext context)
        {
            _httpClient = new HttpClient();
            _context = context;
        }

        public async Task<WeatherModel> GetWeatherAsync(string city)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
            var response = await _httpClient.GetStringAsync(url);
            var data = JObject.Parse(response);

            var weather = new WeatherModel
            {
                City = data["name"].ToString(),
                Temperature = double.Parse(data["main"]["temp"].ToString()),
                Description = data["weather"][0]["description"].ToString(),
                Humidity = double.Parse(data["main"]["humidity"].ToString()),
                WindSpeed = double.Parse(data["wind"]["speed"].ToString())
            };

            var weatherHistory = new WeatherHistory
            {
                City = weather.City,
                Temperature = weather.Temperature,
                Description = weather.Description,
                Humidity = weather.Humidity,
                WindSpeed = weather.WindSpeed,
                Date = DateTime.Now
            };

            _context.WeatherHistories.Add(weatherHistory);
            await _context.SaveChangesAsync();

            return weather;
        }

        public async Task<WeatherAverages> GetWeatherAveragesAsync(string city, DateTime startDate1, DateTime endDate1, DateTime startDate2, DateTime endDate2, DateTime startDate3, DateTime endDate3)
        {
            var period1 = await _context.WeatherHistories
                .Where(w => w.City == city && w.Date >= startDate1 && w.Date <= endDate1)
                .ToListAsync();

            var period2 = await _context.WeatherHistories
                .Where(w => w.City == city && w.Date >= startDate2 && w.Date <= endDate2)
                .ToListAsync();

            var period3 = await _context.WeatherHistories
                .Where(w => w.City == city && w.Date >= startDate3 && w.Date <= endDate3)
                .ToListAsync();

            var average1 = CalculateAverage(period1);
            var average2 = CalculateAverage(period2);
            var average3 = CalculateAverage(period3);

            return new WeatherAverages
            {
                Period1Average = average1,
                Period2Average = average2,
                Period3Average = average3
            };
        }

        private WeatherModel CalculateAverage(List<WeatherHistory> period)
        {
            if (!period.Any()) return null;

            return new WeatherModel
            {
                Temperature = period.Average(p => p.Temperature),
                Humidity = period.Average(p => p.Humidity),
                WindSpeed = period.Average(p => p.WindSpeed)
            };
        }
    }
}
