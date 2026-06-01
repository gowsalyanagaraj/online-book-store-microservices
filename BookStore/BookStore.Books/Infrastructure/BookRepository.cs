using Microsoft.EntityFrameworkCore;
using BookStore.Books.Domain.Interface;
using BookStore.Books.Domain.Models;
using BookStore.Books.Infrastructure.Persistence;

namespace BookStore.Books.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task<List<BookInfo>> GetAllAsync()
        {
            return await _context.Books
                .Select(b => new BookInfo
                {
                    Id = b.Id,
                    Title = b.Title,
                    Price = b.Price,
                    Stock = b.Stock
                })
                .ToListAsync();
        }

        public async Task<BookInfo?> GetByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task AddAsync(BookInfo book)
        {
            _context.Books.Add(book);

            await _context.SaveChangesAsync();
        }
    }
}
