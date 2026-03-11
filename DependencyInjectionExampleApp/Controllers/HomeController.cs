using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ICitiesService _citiesService;

        // Change the constructor to accept the dependency
        // public HomeController(ICitiesService citiesService)
        // {
        //     _citiesService = citiesService;
        // }
        
        [Route("/")]
        public IActionResult Index([FromServices] ICitiesService _citiesService)
        {
            List<string> cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}