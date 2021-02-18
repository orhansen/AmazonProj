using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Creates a Context for our amazon books database
namespace AmazonProj.Models
{
    public class AmazonDBContext : DbContext
    {
        public AmazonDBContext (DbContextOptions<AmazonDBContext> options) : base (options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
