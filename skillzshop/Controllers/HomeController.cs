using Microsoft.AspNetCore.Mvc;
using skillzshop.Data;

namespace skillzshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext appDbContext;

        public HomeController(AppDbContext context)
        {
            appDbContext = context;
        }

        public IActionResult Index()
        {
            var data = appDbContext.Category.ToList();
            return View(data);
        }


    }
}
