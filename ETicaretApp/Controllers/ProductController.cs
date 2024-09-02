using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;

namespace ETicaretApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            //var context = new RepositoryContext(
            //    new DbContextOptionsBuilder<RepositoryContext>().UseSqlite("Data Source = C:\\Users\\LENOVO\\Desktop\\E-Ticaret-MVC\\ProductDb.db").Options
            //);

            //var model = _context.Products.ToList();
            
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }
        public IActionResult Get(int id)
        {
            // Product product = _context.Products.First(p => p.ProductId.Equals(id));
            //return View(product);
            
            var model = _manager.Product.GetOneProduct(id, false);
            return View(model);
        }

    }
}