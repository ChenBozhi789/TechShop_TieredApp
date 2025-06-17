using BusinessLayer;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // POST: /api/order
        [HttpPost]
        public IActionResult AddOrder([FromBody] OrderModel model)
        {
            if (string.IsNullOrWhiteSpace(model.CustomerName))
            {
                return BadRequest("Customer name is required.");
            }

            var entity = _orderService.Add(model);

            return Ok(entity.OrderID);
        }
    }
}
