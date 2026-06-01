using BookStore.Books.Domain.Models;

namespace BookStore.Books.Domain.Interface
{
    public interface IBookRepository
    {
        Task<List<BookInfo>> GetAllAsync();

        Task<BookInfo?> GetByIdAsync(int id);

        Task AddAsync(BookInfo book);
    }
}
