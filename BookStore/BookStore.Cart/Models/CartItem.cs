namespace BookStore.Cart.Models
{
    public class CartItem
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}
