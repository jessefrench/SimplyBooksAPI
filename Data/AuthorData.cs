using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new()
        {
            new() { Id = 1, FirstName = "Jane", LastName = "Austen", Email = "j.austen@example.com", Image = "https://example.com/images/jane_austen.jpg", Favorite = true, UserId = 1 },
            new() { Id = 2, FirstName = "George", LastName = "Orwell", Email = "g.orwell@example.com", Image = "https://example.com/images/george_orwell.jpg", Favorite = true, UserId = 2 },
            new() { Id = 3, FirstName = "Agatha", LastName = "Christie", Email = "a.christie@example.com", Image = "https://example.com/images/agatha_christie.jpg", Favorite = false, UserId = 1 },
            new() { Id = 4, FirstName = "J.K.", LastName = "Rowling", Email = "jk.rowling@example.com", Image = "https://example.com/images/jk_rowling.jpg", Favorite = false, UserId = 3 }
        };
    }
}