using Microsoft.AspNetCore.Mvc;

namespace skillzshop.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
