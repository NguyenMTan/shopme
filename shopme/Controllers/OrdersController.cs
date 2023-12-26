using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopme.Data;

namespace shopme.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBrand = await _context.Orders.ToListAsync();
            return View();
        }
    }
}
