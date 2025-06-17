using Microsoft.AspNetCore.Mvc;
using RestApi.Client;

namespace ClientApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductClient _productClient;

        public ProductController(IProductClient productClient)
        {
            _productClient = productClient;
        }

        // This method used for viewing Product details
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productClient.GetAsync(id);

            return View(product);
        }
    }
}
