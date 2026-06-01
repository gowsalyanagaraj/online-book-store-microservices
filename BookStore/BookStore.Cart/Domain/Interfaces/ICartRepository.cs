using BookStore.Cart.Domain.Models;

namespace BookStore.Cart.Domain.Interfaces
{
    public interface ICartRepository
    {
        Task<List<CartItem>> GetCartItemsAsync();

        Task AddToCartAsync(CartItem item);

        Task RemoveFromCartAsync(int id);
    }
}
