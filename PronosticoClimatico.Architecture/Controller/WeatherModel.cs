using Microsoft.AspNetCore.Mvc;

namespace PronosticoClimatico.Architecture.Controller
{
    public class WeatherModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
