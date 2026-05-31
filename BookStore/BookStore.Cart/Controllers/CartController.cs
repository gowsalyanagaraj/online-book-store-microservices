
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

        [HttpDelete("remove/{id}")]
        public IActionResult RemoveFromCart(int id)
        {
            var item = cart.FirstOrDefault(x => x.Id == id);

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
