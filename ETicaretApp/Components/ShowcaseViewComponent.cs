using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace ETicaretApp.Components
{
    public class ShowcaseViewComponent : ViewComponent
    {
        public readonly IServiceManager _manager;

        public ShowcaseViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var products = _manager.ProductService.GetShowcaseProducts(false);
            return View(products);
        }
    }
}