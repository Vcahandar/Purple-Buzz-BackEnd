using Microsoft.AspNetCore.Mvc;

namespace PurpleFrontToBack.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
