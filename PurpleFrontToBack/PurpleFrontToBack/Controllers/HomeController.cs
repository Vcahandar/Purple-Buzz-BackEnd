using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleFrontToBack.Data;
using PurpleFrontToBack.Models;
using PurpleFrontToBack.ViewModels;
using System.Diagnostics;

namespace PurpleFrontToBack.Controllers
{
    public class HomeController : Controller

    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            SliderImg sliderImg = await _context.SliderImgs.FirstOrDefaultAsync();

            IEnumerable<SliderInfo> sliderInfos = await _context.SliderInfos.ToListAsync();

            IEnumerable<Category> categories= await _context.Categories.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<Product> products = await _context.Products.Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<RecentWork> recentWorks = await _context.RecentWorks.Where(m => !m.SoftDelete).ToListAsync();

            Service service = await _context.Services.FirstOrDefaultAsync();







            HomeVM model = new HomeVM
            {
                SliderImgs = sliderImg,
                SliderInfos = sliderInfos,
                Categories = categories,
                Products=products,
                RecentWorks= recentWorks,
                Services=service

            };

            return View(model);
        }


    }
}