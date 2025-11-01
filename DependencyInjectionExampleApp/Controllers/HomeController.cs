using Microsoft.AspNetCore.Mvc;
using Services;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly CitiesService _citiesService;

        public HomeController()
        {
            _citiesService = new CitiesService(); // here you must use Dependency Injection instead
        }
        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = _citiesService.GetCities();
            // ViewBag.Cities = cities;
            return View(cities);
        }
    }
}
