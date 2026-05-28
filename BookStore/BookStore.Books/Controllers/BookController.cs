using Microsoft.AspNetCore.Mvc;

namespace BookStore.Books.Controllers
{
	[ApiController]
	[Route("api/books")]
	public class BookController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetBooks()
		{
			var books = new[]
			            {
				            new
				            {
					            Id = 1,
					            Title = "Clean Code",
					            Price = 500
				            },
				            new
				            {
					            Id = 2,
					            Title = "ASP.NET Core",
					            Price = 700
				            }
			            };

			return Ok(books);
		}
	}
}
