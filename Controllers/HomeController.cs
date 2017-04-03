using Microsoft.AspNetCore.Mvc;

namespace ekl.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hallo";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
