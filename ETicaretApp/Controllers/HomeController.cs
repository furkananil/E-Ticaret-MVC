using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Welcome";
            return View();
        }
        
    }
}