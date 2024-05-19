using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using MonitoreoClimatico.Architecture.Bussines;
using MonitoreoClimatico.Architecture.Bussines.Model;

namespace MonitoreoClimatico.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return View("Index");
            }

            var weather = await _weatherService.GetWeatherAsync(city);
            return View("Index", weather);
        }

        public async Task<IActionResult> Averages(string city, DateTime startDate1, DateTime endDate1, DateTime startDate2, DateTime endDate2, DateTime startDate3, DateTime endDate3)
        {
            if (string.IsNullOrEmpty(city))
            {
                return View("Index");
            }

            var averages = await _weatherService.GetWeatherAveragesAsync(city, startDate1, endDate1, startDate2, endDate2, startDate3, endDate3);
            return View("Averages", averages);
        }
    }

}