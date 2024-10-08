﻿using Microsoft.EntityFrameworkCore;
using SimplyBooks.Models;

namespace SimplyBooks.Endpoints
{
    public class AuthorEndpoints
    {
        public static void Map(WebApplication app)
        {
            // get all authors
            app.MapGet("/authors", (SimplyBooksDbContext db) =>
            {
                return db.Authors.ToList();
            });

            // get all authors by user
            app.MapGet("/authors/users/{userId}", (SimplyBooksDbContext db, int userId) =>
            {
                return db.Authors
                       .Where(author => author.UserId == userId)
                       .Include(author => author.Books)
                       .ToList();
            });

            // get a single author + author's books
            app.MapGet("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
            {
                Author author = db.Authors
                                .Include(author => author.Books)
                                .SingleOrDefault(author => author.Id == authorId);

                if (author == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(author);
            });

            // create an author
            app.MapPost("/authors", (SimplyBooksDbContext db, Author newAuthor) =>
            {
                db.Authors.Add(newAuthor);
                db.SaveChanges();
                return Results.Created($"authors/{newAuthor.Id}", newAuthor);
            });

            // update an author
            app.MapPut("/authors/{authorId}", (SimplyBooksDbContext db, int authorId, Author author) =>
            {
                Author authorToUpdate = db.Authors.SingleOrDefault(author => author.Id == authorId);

                if (authorToUpdate == null)
                {
                    return Results.NotFound();
                }

                authorToUpdate.FirstName = author.FirstName;
                authorToUpdate.LastName = author.LastName;
                authorToUpdate.Email = author.Email;
                authorToUpdate.Image = author.Image;
                authorToUpdate.Favorite = author.Favorite;

                db.SaveChanges();
                return Results.Ok(authorToUpdate);
            });

            // delete an author + author's books
            app.MapDelete("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
            {
                Author author = db.Authors
                    .Include(author => author.Books)
                    .SingleOrDefault(author => author.Id == authorId);

                if (author == null)
                {
                    return Results.NotFound();
                }

                db.Books.RemoveRange(author.Books);
                db.Authors.Remove(author);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}