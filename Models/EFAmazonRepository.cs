using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Model to create repository used in database
namespace AmazonProj.Models
{
    public class EFAmazonRepository : IAmazonRepository
    {
        private AmazonDBContext _context;

        //Constructor for the context.
        public EFAmazonRepository (AmazonDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
