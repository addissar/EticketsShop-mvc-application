using Microsoft.AspNetCore.Mvc;

namespace Etickets.Controllers
{
    public class ProducersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
