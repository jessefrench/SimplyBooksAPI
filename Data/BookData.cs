using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class BookData
    {
        public static List<Book> Books = new()
        {
            new() { Id = 1, AuthorId = 1, Title = "Pride and Prejudice", Description = "A classic novel of manners.", Image = "https://example.com/images/pride_prejudice.jpg", Price = 9.99m, Sale = false, UserId = 1 },
            new() { Id = 2, AuthorId = 2, Title = "1984", Description = "A dystopian social science fiction novel.", Image = "https://example.com/images/1984.jpg", Price = 14.99m, Sale = true, UserId = 2 },
            new() { Id = 3, AuthorId = 3, Title = "Murder on the Orient Express", Description = "A famous detective novel.", Image = "https://example.com/images/orient_express.jpg", Price = 12.99m, Sale = false, UserId = 1 },
            new() { Id = 4, AuthorId = 4, Title = "Harry Potter and the Sorcerer's Stone", Description = "The first book in the Harry Potter series.", Image = "https://example.com/images/hp_sorcerer_stone.jpg", Price = 19.99m, Sale = true, UserId = 3 }
        };
    }
}