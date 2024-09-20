using Entities.Models;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace ETicaretApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(ProductRequestParameters p)
        {
            //var context = new RepositoryContext(
            //    new DbContextOptionsBuilder<RepositoryContext>().UseSqlite("Data Source = C:\\Users\\LENOVO\\Desktop\\E-Ticaret-MVC\\ProductDb.db").Options
            //);

            //var model = _context.Products.ToList();
            
            var model = _manager.ProductService.GetAllProductsWithDetails(p);
            return View(model);
        }
        public IActionResult Get([FromRoute(Name="id")] int id)
        {
            // Product product = _context.Products.First(p => p.ProductId.Equals(id));
            //return View(product);
            
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }

    }
}