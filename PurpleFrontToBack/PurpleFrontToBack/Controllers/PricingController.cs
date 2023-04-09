using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleFrontToBack.Data;
using PurpleFrontToBack.Models;

namespace PurpleFrontToBack.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index()
        {
            IEnumerable<Package> packages = await _context.Packages.Where(m => !m.SoftDelete).Include(m => m.Offers).ToListAsync();

            return View(packages);
        }
    }
}
