using Microsoft.EntityFrameworkCore;
using SimplyBooks.Models;
using SimplyBooks.Data;

public class SimplyBooksDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }

    public SimplyBooksDbContext(DbContextOptions<SimplyBooksDbContext> context) : base(context) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(AuthorData.Authors);
        modelBuilder.Entity<Book>().HasData(BookData.Books);
        modelBuilder.Entity<User>().HasData(UserData.Users);
    }
}