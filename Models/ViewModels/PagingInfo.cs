using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Model created to assist in pagination. Contains the details of what a page should include, the total pages, and the current page.
namespace AmazonProj.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}

