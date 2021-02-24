using AmazonProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AmazonProj.Models.ViewModels;

//Home controller. This controlls the get and post requests handled by the application.
namespace AmazonProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Private variable for class use
        private IAmazonRepository _repository;

        //Int to determine the amount of items we want listed on a single page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IAmazonRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //primary get action. will populate index page with the Books in the database.
        public IActionResult Index(int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                    .OrderBy(b => b.BookID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                ,
                PagingInfo= new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
