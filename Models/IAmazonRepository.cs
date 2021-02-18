using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Allows the repository to be queryable for future use.
namespace AmazonProj.Models
{
    public interface IAmazonRepository
    {
        IQueryable<Book> Books { get; }
    }
}
