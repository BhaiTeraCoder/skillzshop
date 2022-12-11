using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skillzshop.Data;
using skillzshop.Models;

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

        [HttpGet]
        public async Task<IActionResult> Index(String NameSearch)
        {
            ViewData["getSkill"] = NameSearch;

            var skillquery = from x in _context.Skills select x;
            if (!String.IsNullOrWhiteSpace(NameSearch))
            {
                skillquery = skillquery.Where(x => x.Name.Contains(NameSearch));
            }
            return View(await skillquery.AsNoTracking().ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name", "Description", "Price", "SellerName", "CategoryId")]Skills skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }
            _context.Add(skill);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //Get: Skills/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var skillDetails = await _context.Skills.FirstOrDefaultAsync(n => n.SkillId == id);
            if (skillDetails == null) return View("Empty");
            return View(skillDetails);
        }
    }
}
