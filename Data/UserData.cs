using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class UserData
    {
        public static List<User> Users = new()
        {
            new User { Id = 1, Username = "booklover", Email = "booklover@example.com" },
            new User { Id = 2, Username = "literarygenius", Email = "genius@example.com" },
            new User { Id = 3, Username = "avidreader", Email = "avid@example.com" }
        };
    }
}