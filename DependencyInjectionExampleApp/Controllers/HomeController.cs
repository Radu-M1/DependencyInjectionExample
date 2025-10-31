using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
