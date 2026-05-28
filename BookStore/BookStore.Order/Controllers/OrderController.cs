using Microsoft.AspNetCore.Mvc;

namespace BookStore.Order.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrderController : ControllerBase
	{
		private readonly IHttpClientFactory _factory;

		public OrderController(IHttpClientFactory factory)
		{
			_factory = factory;
		}

		[HttpPost]
		public async Task<IActionResult> PlaceOrder()
		{
			var client = _factory.CreateClient();

			try
			{
				var response = await client.PostAsync("http://localhost:5004/api/payments", null);

				if(response.IsSuccessStatusCode)
				{
					return Ok(new { Message = "Order Placed Successfully" });
				}

				return BadRequest(new { Message = "Payment Failed" });
			}
			catch
			{
				return Problem("Payment Service is unavailable");
			}
		}
	}
}
