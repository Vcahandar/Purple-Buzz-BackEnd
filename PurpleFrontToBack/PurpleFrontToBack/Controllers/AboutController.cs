using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleFrontToBack.Data;
using PurpleFrontToBack.Models;
using PurpleFrontToBack.ViewModels;

namespace PurpleFrontToBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            Banner banner = await _context.Banners.FirstOrDefaultAsync();

            Team team = await _context.Teams.Where(m => !m.SoftDelete).Include(m => m.TeamMembers).FirstOrDefaultAsync();

            AboutVM aboutVM = new AboutVM()
            {
                Banners = banner,
                Team= team,
            };


            return View(aboutVM);
        }
    }
}
