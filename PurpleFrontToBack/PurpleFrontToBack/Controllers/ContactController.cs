using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleFrontToBack.Data;
using PurpleFrontToBack.Models;

namespace PurpleFrontToBack.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context= context;
        }
        public async Task<IActionResult>  Index()
        {
            Contact contact = await _context.Contacts.FirstOrDefaultAsync();

            return View(contact);
        }
    }
}
