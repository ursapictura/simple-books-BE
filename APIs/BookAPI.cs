using Microsoft.EntityFrameworkCore;
using System.Reflection;
using SimplyBooks.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SimplyBooks.APIs
{
    public class BookAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL BOOKS BY USER
            app.MapGet("/books/users/{userId}", (SimplyBooksDbContext db, int userId) =>
            {
                return db.Books
                        .Where(b => b.UserId == userId)
                        .Include(b => b.Author)
                        .ToList();
            });

            //GET BOOK BY BOOK ID
            app.MapGet("/books/{bookId}", (SimplyBooksDbContext db, int bookId) =>
            {
                Book book = db.Books
                            .Include(b => b.Author)
                            .SingleOrDefault(b => b.Id == bookId);

                if (book == null)
                {
                    return Results.NotFound("That book does not exist");
                }

                return Results.Ok(book);
            });

            // CREATE USER BOOK
            app.MapPost("/books", (SimplyBooksDbContext db, Book newBook) =>
            {
                Book addBook = new()
                {
                    Title = newBook.Title,
                    Description = newBook.Description,
                    AuthorId = newBook.AuthorId,
                    Price = newBook.Price,
                    Sale = newBook.Sale,
                    Image = newBook.Image,
                    UserId = newBook.UserId,
                };

                db.Books.Add(addBook);
                db.SaveChanges();
                return Results.Created($"books/{addBook.Id}", addBook);
            });

            app.MapDelete("/books/{bookId}", (SimplyBooksDbContext db, int bookId) =>
            {
                Book book = db.Books.SingleOrDefault(b => b.Id == bookId);

                if (book == null)
                {
                    return Results.NotFound();
                }

                db.Books.Remove(book);
                db.SaveChanges();
                return Results.NoContent();
            });

            app.MapPut("/books/{bookId}", (SimplyBooksDbContext db, int bookId, Book book) =>
            {
                Book updateBook = db.Books.SingleOrDefault(b => b.Id == bookId);

                if (updateBook == null)
                {
                    return Results.NotFound();
                }

                else if (!db.Users.Any(user => user.Id == book.UserId))
                {
                    return Results.NotFound("No user found");
                }

                updateBook.Title = book.Title;
                updateBook.Description = book.Description;
                updateBook.AuthorId = book.AuthorId;
                updateBook.Price = book.Price;
                updateBook.Sale = book.Sale;
                updateBook.Image = book.Image;
                updateBook.UserId = book.UserId;

                db.SaveChanges();
                return Results.Ok(updateBook);
            });
        }
    }
}