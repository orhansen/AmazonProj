using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This initializes the data of the database. Only neccessary for initial data loading.
namespace AmazonProj.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            AmazonDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AmazonDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book //Loading the Data based on the Book Model created previously.
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Pages = 1488,
                        Price = 9.95
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Pages = 944,
                        Price = 14.58
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Pages = 832,
                        Price = 21.54
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Pages = 864,
                        Price = 11.61
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Pages = 528,
                        Price = 13.33
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Pages = 288,
                        Price = 15.95
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 304,
                        Price = 14.99
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 240,
                        Price = 21.66
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Pages = 400,
                        Price = 29.16
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Pages = 642,
                        Price = 15.03
                    },
                    new Book
                    {
                        Title = "Airborn",
                        AuthorFirst = "Kenneth",
                        AuthorLast = "Oppel",
                        Publisher = "HarperCollins",
                        ISBN = "978-0060531829",
                        Classification = "Fiction",
                        Category = "Teen",
                        Pages = 544,
                        Price = 9.99
                    },
                    new Book
                    {
                        Title = "How to Win Friends and Influence People",
                        AuthorFirst = "Dale",
                        AuthorLast = "Carnegie",
                        Publisher = "Pocket Books",
                        ISBN = "978-0671027032",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Pages = 288,
                        Price = 11.99
                    },
                    new Book
                    {
                        Title = "If You Give a Mouse a Cookie",
                        AuthorFirst = "Laura",
                        AuthorLast = "Numeroff",
                        Publisher = "HarperCollins",
                        ISBN = "978-0060245863",
                        Classification = "Fiction",
                        Category = "Children",
                        Pages = 40,
                        Price = 10.88,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
