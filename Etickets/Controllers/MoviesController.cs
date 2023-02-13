using Microsoft.AspNetCore.Mvc;

namespace Etickets.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
