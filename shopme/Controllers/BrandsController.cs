using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopme.Data;

namespace shopme.Controllers
{
    public class BrandsController : Controller
    {
        private readonly AppDbContext _context;

        public BrandsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBrand = await _context.Brands.ToListAsync();
            return View();
        }
    }
}
