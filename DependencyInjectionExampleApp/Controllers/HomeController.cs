using Microsoft.AspNetCore.Mvc;
// using Services;
using ServiceContracts;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICitiesService _citiesService;

        public HomeController()
        {
            // _citiesService = new CitiesService(); // here you must use Dependency Injection instead
            _citiesService = null;
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
