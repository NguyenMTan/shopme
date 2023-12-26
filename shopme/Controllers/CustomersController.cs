using Microsoft.AspNetCore.Mvc;
using shopme.Data;

namespace shopme.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Customers.ToList();
            return View();
        }
    }
}
