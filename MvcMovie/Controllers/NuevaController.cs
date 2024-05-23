using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class NuevaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
