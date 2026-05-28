using Microsoft.AspNetCore.Mvc;
using BookStore.Books.Models;

namespace BookStore.Books.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private static readonly List<Book> books = new()
        {
            new Book { Id = 1, Title = "The Silent Patient", Price = 500, Stock = 10 },
            new Book { Id = 2, Title = "The Housemaid", Price = 600, Stock = 5 },
            new Book { Id = 2, Title = "Can We Be Strangers Again?", Price = 300, Stock = 15 },
            new Book { Id = 4, Title = "The Love Hypothesis", Price = 300, Stock = 10 }, 
            new Book { Id = 5, Title = "Twisted Love", Price = 500, Stock = 15 }, 
            new Book { Id = 6, Title = "The Thursday Murder Club", Price = 400, Stock = 5 }
        };

        [HttpGet("displayall")]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }

        [HttpGet("search/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }
    }
}
