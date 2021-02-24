using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//A new model to enumerate the book list, using the additional pagination features.
namespace AmazonProj.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
