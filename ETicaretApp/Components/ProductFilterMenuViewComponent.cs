using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.Components
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}