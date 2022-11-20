using Microsoft.AspNetCore.Mvc;
using skillzshop.Data;

namespace skillzshop.Controllers
{
    public class SkillsController : Controller
    {
        private readonly AppDbContext _context;
        public SkillsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allSkills = _context.Skills.ToList();
            return View(allSkills);
        }
    }
}
