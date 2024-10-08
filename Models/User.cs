namespace SimplyBooks.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
    }
}