using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var result = _productService.GetList();
            if (result.IsSuccess)
            {
                return View(result.Data);
            }
            return Content(result.Message);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            product.CategoryID = 1;
            if (_productService.Add(product).IsSuccess)
            {
                return RedirectToAction("Index");
            }
            var res = _productService.Add(product).Message;
            return View(res);

        }




        public IActionResult Details(int id)
        {
            return View();

        }




    }
}
