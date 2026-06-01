using BookStore.Cart.Domain.Interfaces;
using BookStore.Cart.Domain.Models;

namespace BookStore.Cart.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;

        public CartService(ICartRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            return await _repository.GetCartItemsAsync();
        }

        public async Task AddToCartAsync(CartItem item)
        {
            await _repository.AddToCartAsync(item);
        }

        public async Task RemoveFromCartAsync(int id)
        {
            await _repository.RemoveFromCartAsync(id);
        }
    }
}