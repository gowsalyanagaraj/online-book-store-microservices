using Microsoft.AspNetCore.Mvc;

namespace BookStore.Payment.Controllers
{
	[ApiController]
	[Route("api/payment")]
	public class PaymentController : ControllerBase
	{
		[HttpPost("pay")]
		public IActionResult MakePayment()
		{
			return Ok(new
			          {
				          Message = "Payment Successful"
			          });
		}
	}
}
