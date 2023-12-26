using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopme.Data;

namespace shopme.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBrand = await _context.Products.ToListAsync();
            return View();
        }
    }
}
