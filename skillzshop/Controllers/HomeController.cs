using Microsoft.AspNetCore.Mvc;

namespace skillzshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
