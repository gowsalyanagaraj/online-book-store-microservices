using Microsoft.AspNetCore.Mvc;

namespace BookStore.Order.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        public static string OrderStatus = "No Order";

        public static List<OrderItem> Orders = new();

        [HttpPost("processing")]
        public IActionResult Processing()
        {
            OrderStatus = "Order Processing";

            return Ok(new
            {
                Message = OrderStatus
            });
        }

        [HttpPost("success")]
        public IActionResult Success()
        {
            OrderStatus = "Order Successful";

            Orders.Add(new OrderItem
            {
                Id = Orders.Count + 1,
                Status = "Success"
            });

            return Ok(new
            {
                Message = OrderStatus
            });
        }

        [HttpPost("cancel")]
        public IActionResult Cancel()
        {
            OrderStatus = "Order Cancelled";

            return Ok(new
            {
                Message = OrderStatus
            });
        }

        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok(new
            {
                Status = OrderStatus
            });
        }

        [HttpGet("all")]
        public IActionResult GetOrders()
        {
            return Ok(Orders);
        }
    }

    public class OrderItem
    {
        public int Id { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}