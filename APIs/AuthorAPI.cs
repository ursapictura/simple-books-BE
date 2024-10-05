using Microsoft.EntityFrameworkCore;
using System.Reflection;
using SimplyBooks.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.SignalR;

namespace SimplyBooks.APIs
{
    public class AuthorAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL AUTHORS BY USER
            app.MapGet("/authors/users/{userId}", (SimplyBooksDbContext db, int userId) =>
            {
                return db.Authors
                       .Where(a => a.UserId == userId)
                       .Include(a => a.Books)
                       .ToList();
            });

            // GET SINGLE AUTHOR BY ID
            app.MapGet("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
            {
                Author author = db.Authors
                                .Include(a => a.Books)
                                .SingleOrDefault(a => a.Id == authorId);

                if (author == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(author);
            });

            // CREATE AUTHOR
            app.MapPost("/authors", (SimplyBooksDbContext db, Author newAuthor) =>
            {
                Author addAuthor = new()
                {
                    FirstName = newAuthor.FirstName,
                    LastName = newAuthor.LastName,
                    Email = newAuthor.Email,
                    Image = newAuthor.Image,
                    Favorite = newAuthor.Favorite,
                    UserId = newAuthor.UserId,
                };

                db.Authors.Add(addAuthor);
                db.SaveChanges();
                return Results.Created($"authors/{addAuthor.Id}", addAuthor);
            });

            // DELETE AUTHOR
            app.MapDelete("/authors/{authorId}", (SimplyBooksDbContext db, int authorId) =>
            {
                Author author = db.Authors.SingleOrDefault(a => a.Id == authorId);

                if (author == null)
                {
                    return Results.NotFound();
                }

                db.Authors.Remove(author);
                db.SaveChanges();
                return Results.NoContent();
            });

            // UPDATE AUTHOR
            app.MapPut("/authors/{authorId}", (SimplyBooksDbContext db, int authorId, Author author) =>
            {
                Author updateAuthor = db.Authors.SingleOrDefault(a => a.Id == authorId);

                if (updateAuthor == null)
                {
                    return Results.NotFound();
                }

                if (!db.Users.Any(user => user.Id == author.UserId))
                {
                    return Results.NotFound("No user found.");
                }

                updateAuthor.FirstName = author.FirstName;
                updateAuthor.LastName = author.LastName;
                updateAuthor.Email = author.Email;
                updateAuthor.Image = author.Image;
                updateAuthor.Favorite = author.Favorite;
                updateAuthor.UserId = author.UserId;

                db.SaveChanges();
                return Results.Ok(updateAuthor);
            });
        }
    };
}