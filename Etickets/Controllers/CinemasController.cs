using Microsoft.AspNetCore.Mvc;

namespace Etickets.Controllers
{
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
