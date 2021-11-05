using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi;

namespace WebApi
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Authors.AddRange(new Author { Name = "Eric", Surname = "Ries", birthDate = new DateTime(1914, 04, 13) }, new Author { Name = "Charlotte Perkins", Surname = "Gilman", birthDate = new DateTime(1952, 06, 7) }, new Author { Name = "Frank", Surname = "Herbert", birthDate = new DateTime(1915, 12, 20) });

                context.Genres.AddRange(new Genre { Name = "Personal Growth" }, new Genre { Name = "Science Fiction" }, new Genre { Name = "Roman" });


                context.Books.AddRange(
                    new Book
                    {
                        // Id = 1,
                        Title = "Lean Startup",
                        GenreId = 1, //Personal Growth
                        PageCount = 200,
                        PublishDate = new DateTime(2001, 06, 12),
                        AuthorId = 1,//Eric Ries
                    },
                    new Book
                    {
                        //   Id = 2,
                        Title = "Herland",
                        GenreId = 2, //Science Fiction
                        PageCount = 250,
                        PublishDate = new DateTime(2010, 05, 23),
                        AuthorId = 2//Charlotte Perkins Gilman
                    },
                    new Book
                    {
                        //   Id = 3,
                        Title = "Dune",
                        GenreId = 2, //Science Fiction
                        PageCount = 500,
                        PublishDate = new DateTime(2001, 12, 21),
                        AuthorId = 3//Aziz Nesin
                    });

                context.SaveChanges();
            }
        }
    }
}