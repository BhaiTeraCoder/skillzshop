using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skillzshop.Data;
using skillzshop.Models;

namespace skillzshop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allCategory = _context.Category;
            return View(allCategory.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Index(String NameSearch)
        {
            ViewData["getCategory"] = NameSearch;

            var categoryquery = from x in _context.Category select x;
            if (!String.IsNullOrWhiteSpace(NameSearch))
            {
                categoryquery = categoryquery.Where(x => x.CategoryId.Equals(NameSearch));
            }
            return View(await categoryquery.AsNoTracking().ToListAsync());
        }


        //Get: Category/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var categoryDetails = await _context.Category.FirstOrDefaultAsync(n => n.CategoryId == id);
            if (categoryDetails == null) return View("Empty");
            return View(categoryDetails);
        }
    }
}
