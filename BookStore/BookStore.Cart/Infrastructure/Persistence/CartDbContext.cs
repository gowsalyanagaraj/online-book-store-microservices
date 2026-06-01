using BookStore.Cart.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace BookStore.Cart.Infrastructure.Persistence
{
    public class CartDbContext : DbContext
    {
        public CartDbContext(DbContextOptions<CartDbContext> options)
            : base(options)
        {
        }

        public DbSet<CartItem> CartItems => Set<CartItem>();
    }
}
