using Entities.Models;
using Entities.RequestParameters;
using ETicaretApp.Models;
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
            
            // var model = _manager.ProductService.GetAllProductsWithDetails(p);
            // return View(model);

            var products = _manager.ProductService.GetAllProductsWithDetails(p);
            var pagination = new Pagination()
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.ProductService.GetAllProducts(false).Count()
            };
            return View(new ProductListViewModel()
            {
                Products = products,
                Pagination = pagination
            });
        }
        public IActionResult Get([FromRoute(Name="id")] int id)
        {
            // Product product = _context.Products.First(p => p.ProductId.Equals(id));
            //return View(product);
            
            var model = _manager.ProductService.GetOneProduct(id, false);
            ViewData["Title"] = model?.ProductName;
            return View(model);
        }

    }
}