using BookStore.Books.Domain.Interface;
using BookStore.Books.Domain.Models;

namespace BookStore.Books.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BookInfo>> GetBooksAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<BookInfo?> GetBookByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddBookAsync(BookInfo book)
        {
            await _repository.AddAsync(book);
        }
    }
}
