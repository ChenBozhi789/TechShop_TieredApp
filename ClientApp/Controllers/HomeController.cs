using BusinessLayer;
using ClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;
using RestApi.Client;
using DataAccessLayer.Models;

namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductClient _productClient;
        private readonly IBrandClient _brandClient;

        public HomeController(ILogger<HomeController> logger, IProductClient productClient, IBrandClient brandClient)
        {
            _logger = logger;
            _productClient = productClient;
            _brandClient = brandClient;
        }

        public async Task<IActionResult> Index(int? brandId)
        {
            var brands = await _brandClient.GetAllAsync();
            var products = await _productClient.GetAllAsync();

            if (brandId.HasValue)
            {
                products = products.Where(p => p.BrandID == brandId.Value).ToList();
            } 

            var viewModel = new ProductViewModel
            {
                Products = products,
                Brands = brands
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
