using BookStore.Books.Domain.Models;

namespace BookStore.Books.Domain.Interface
{
    public interface IBookService
    {
        Task<List<BookInfo>> GetBooksAsync();

        Task<BookInfo?> GetBookByIdAsync(int id);

        Task AddBookAsync(BookInfo book);
    }
}
