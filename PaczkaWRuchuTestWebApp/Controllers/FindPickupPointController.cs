using Microsoft.AspNetCore.Mvc;

namespace PaczkaWRuchuTestWebApp.Controllers
{
    public class FindPickupPointController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
