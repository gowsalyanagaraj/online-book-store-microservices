using Microsoft.AspNetCore.Mvc;

namespace BookStore.Users.Controllers
{
	[ApiController]
	[Route("api/users")]
	public class UserController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetUsers()
		{
			var users = new[]
			            {
				            new { Id = 1, Name = "John" },
				            new { Id = 2, Name = "Alice" }
			            };

			return Ok(users);
		}
	}
}
