using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}