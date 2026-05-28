using Microsoft.AspNetCore.Mvc;
using BookStore.Cart.Models;

namespace BookStore.Cart.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private static readonly List<CartItem> cart = new();

        [HttpGet("showCart")]
        public IActionResult GetCart()
        {
            return Ok(cart);
        }

        [HttpPost("add")]
        public IActionResult AddToCart([FromBody] CartItem item)
        {
            cart.Add(item);

            return Ok(new
            {
                Message = "Book added to cart"
            });
        }

        [HttpDelete("remove/{bookId}")]
        public IActionResult RemoveFromCart(int bookId)
        {
            var item = cart.FirstOrDefault(x => x.BookId == bookId);

            if (item == null)
                return NotFound();

            cart.Remove(item);

            return Ok(new
            {
                Message = "Book removed from cart"
            });
        }
    }
}
