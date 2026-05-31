using System.ComponentModel.DataAnnotations;

namespace BookStore.Order.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    [Range(1, 10000)] 
    public decimal Price { get; set; }
}




