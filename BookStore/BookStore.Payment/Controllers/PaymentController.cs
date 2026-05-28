using Microsoft.AspNetCore.Mvc;

namespace BookStore.Payment.Controllers
{
	[ApiController]
	[Route("api/payments")]
	public class PaymentController : ControllerBase
	{
		[HttpPost]
		public IActionResult MakePayment()
		{
			return Ok(new
			          {
				          Message = "Payment Successful"
			          });
		}
	}
}
