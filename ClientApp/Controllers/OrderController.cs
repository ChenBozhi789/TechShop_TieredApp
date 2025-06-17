using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using RestApi.Client;

namespace ClientApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductClient _productClient;
        private readonly IOrderClient _orderClient;

        public OrderController(IProductClient productClient, IOrderClient orderClient)
        {
            _productClient = productClient;
            _orderClient = orderClient;
        }

        // Get ProductID and quantity
        [HttpGet]
        public async Task<IActionResult> Checkout(int productId, int quantity)
        {
            var product = await _productClient.GetAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Quantity = quantity;
            return View(product);
        }

        // Send POST request to database
        [HttpPost]
        public async Task<IActionResult> SubmitOrder(OrderModel model)
        {
            Console.WriteLine($"ProductID: {model.ProductID}");

            model.TimeStamp = DateTime.Now;
            int newOrderId = await _orderClient.AddAsync(model);

            return RedirectToAction("Index", "Home");
        }
    }
}
