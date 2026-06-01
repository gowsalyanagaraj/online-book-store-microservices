using BookStore.Books.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Books.Infrastructure.Persistence
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookInfo> Books => Set<BookInfo>();
    }
}
