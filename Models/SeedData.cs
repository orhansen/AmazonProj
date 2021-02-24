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
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Fiction, Classic",
                        Pages = 1488,
                        Price = 9.95
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Non-Fiction, Biography",
                        Pages = 944,
                        Price = 14.58
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Non-Fiction, Biography",
                        Pages = 832,
                        Price = 21.54
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category = "Non-Fiction, Biography",
                        Pages = 864,
                        Price = 11.61
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Non-Fiction, Historical",
                        Pages = 528,
                        Price = 13.33
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Fiction, Historical Fiction",
                        Pages = 288,
                        Price = 15.95
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Non-Fiction, Self-Help",
                        Pages = 304,
                        Price = 14.99
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Non-Fiction, Self-Help",
                        Pages = 240,
                        Price = 21.66
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Non-Fiction, Business",
                        Pages = 400,
                        Price = 29.16
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Fiction, Thrillers",
                        Pages = 642,
                        Price = 15.03
                    },
                    new Book
                    {
                        Title = "Airborn",
                        Author = "Kenneth Oppel",
                        Publisher = "HarperCollins",
                        ISBN = "978-0060531829",
                        Category = "Fiction, Teen",
                        Pages = 544,
                        Price = 9.99
                    },
                    new Book
                    {
                        Title = "How to Win Friends and Influence People",
                        Author = "Dale Carnegie",
                        Publisher = "Pocket Books",
                        ISBN = "978-0671027032",
                        Category = "Self Improvement",
                        Pages = 288,
                        Price = 11.99
                    },
                    new Book
                    {
                        Title = "Green Eggs and Ham",
                        Author = "Dr.Suess",
                        Publisher = "Random House",
                        ISBN = "978-0394800165",
                        Category = "Fiction, Children",
                        Pages = 65,
                        Price = 4.79,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
