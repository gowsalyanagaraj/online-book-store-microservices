using BookStore.Order.Models;

namespace BookStore.Order.Data
{

    public static class BookRepository
    {
        public static List<Book> Books =
        [
            new()
        {
            Id = 1,
            Title = "Clean Code",
            Author = "Robert Martin",
            Price = 500
        },

        new()
        {
            Id = 2,
            Title = "C# in Depth",
            Author = "Jon Skeet",
            Price = 700
        }
        ];
    }
}
