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

        public IViewComponentResult Invoke(string page = "default")
        {
            var products = _manager.ProductService.GetShowcaseProducts(false);
            return page.Equals("default") ?
            View(products) : View("List", products);
        }
    }
}