using BookStore.Cart.Domain.Interfaces;
using BookStore.Cart.Domain.Models;
using BookStore.Cart.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
namespace BookStore.Cart.Infrastructure.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly CartDbContext _context;

        public CartRepository(CartDbContext context)
        {
            _context = context;
        }

        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            return await _context.CartItems.ToListAsync();
        }

        public async Task AddToCartAsync(CartItem item)
        {
            _context.CartItems.Add(item);

            await _context.SaveChangesAsync();
        }

        public async Task RemoveFromCartAsync(int id)
        {
            var item = await _context.CartItems.FindAsync(id);

            if (item != null)
            {
                _context.CartItems.Remove(item);

                await _context.SaveChangesAsync();
            }
        }
    }
}