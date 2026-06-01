namespace BookStore.Cart.Domain.Models
{
    public class CartItem
    {
        
  
       
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
