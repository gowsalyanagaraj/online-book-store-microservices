
using BookStore.Cart.Domain.Interfaces;
using BookStore.Cart.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Cart.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;

        public CartController(ICartService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetCart()
        {
            var items = await _service.GetCartItemsAsync();

            return Ok(items);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart(CartItem item)
        {
            await _service.AddToCartAsync(item);

            return Ok();
        }

        [HttpDelete("remove/{id}")]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            await _service.RemoveFromCartAsync(id);

            return Ok();
        }
    }
}
