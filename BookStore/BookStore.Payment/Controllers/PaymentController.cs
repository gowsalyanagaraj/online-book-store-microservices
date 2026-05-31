using Microsoft.AspNetCore.Mvc;

namespace BookStore.Payment.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        public static string PaymentStatus = "Not Started";

        [HttpPost("start")]
        public IActionResult Start()
        {
            PaymentStatus = "Payment Processing";

            return Ok(new
            {
                Message = PaymentStatus
            });
        }

        [HttpPost("success")]
        public IActionResult Success()
        {
            PaymentStatus = "Payment Successful";

            return Ok(new
            {
                Message = PaymentStatus
            });
        }

        [HttpPost("cancel")]
        public IActionResult Cancel()
        {
            PaymentStatus = "Payment Cancelled";

            return Ok(new
            {
                Message = PaymentStatus
            });
        }

        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok(new
            {
                Status = PaymentStatus
            });
        }
    }
}