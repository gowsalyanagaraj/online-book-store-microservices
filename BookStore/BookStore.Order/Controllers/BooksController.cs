using BookStore.Order.Data;
using BookStore.Order.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Order.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(BookRepository.Books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = BookRepository.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            book.Id = BookRepository.Books.Max(x => x.Id) + 1;

            BookRepository.Books.Add(book);

            return CreatedAtAction(
                nameof(GetBookById),
                new { id = book.Id },
                book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var book = BookRepository.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
                return NotFound();

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Price = updatedBook.Price;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult UpdatePrice(int id, decimal price)
        {
            var book = BookRepository.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
                return NotFound();

            book.Price = price;

            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = BookRepository.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
                return NotFound();

            BookRepository.Books.Remove(book);

            return NoContent();
        }

    }
}
