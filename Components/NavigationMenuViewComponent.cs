using AmazonProj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//A Component that will assist in displaying the navigation menu view on our pages
namespace AmazonProj.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private IAmazonRepository repository;

        public NavigationMenuViewComponent (IAmazonRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
