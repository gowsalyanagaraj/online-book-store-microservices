using BookStore.Books.Domain.Interface;
using BookStore.Books.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Books.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet("displayall")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _service.GetBooksAsync();

            return Ok(books);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddBook(BookInfo book)
        {
            await _service.AddBookAsync(book);

            return Ok();
        }
    }
}
