using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //var allSkills = _context.Skills.ToList();
            var allSkills = _context.Skills.Include(c => c.Category);
            return View(allSkills.ToList());
        }
    }
}
