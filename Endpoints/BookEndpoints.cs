using Microsoft.EntityFrameworkCore;
using SimplyBooks.Models;

namespace SimplyBooks.Endpoints
{
    public class BookEndpoints
    {
        public static void Map(WebApplication app)
        {
            // get all books
            app.MapGet("/books", (SimplyBooksDbContext db) =>
            {
                return db.Books.ToList();
            });

            // get a single book + author details
            app.MapGet("/books/{id}", (SimplyBooksDbContext db, int id) =>
            {
                Book book = db.Books
                                .Include(book => book.Author)
                                .SingleOrDefault(book => book.Id == id);

                if (book == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(book);
            });

            // create a book
            app.MapPost("/books", (SimplyBooksDbContext db, Book newBook) =>
            {
                db.Books.Add(newBook);
                db.SaveChanges();
                return Results.Created($"books/{newBook.Id}", newBook);
            });

            // update a book
            app.MapPut("/books/{id}", (SimplyBooksDbContext db, int id, Book book) =>
            {
                Book bookToUpdate = db.Books.SingleOrDefault(book => book.Id == id);

                if (bookToUpdate == null)
                {
                    return Results.NotFound();
                }

                bookToUpdate.Title = book.Title;
                bookToUpdate.Description = book.Description;
                bookToUpdate.Image = book.Image;
                bookToUpdate.Price = book.Price;
                bookToUpdate.Sale = book.Sale;

                db.SaveChanges();
                return Results.Ok(bookToUpdate);
            });

            // delete a book
            app.MapDelete("/books/{id}", (SimplyBooksDbContext db, int id) =>
            {
                Book book = db.Books.SingleOrDefault(book => book.Id == id);

                if (book == null)
                {
                    return Results.NotFound();
                }

                db.Books.Remove(book);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}