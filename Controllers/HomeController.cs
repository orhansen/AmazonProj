using AmazonProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//Home controller. This controlls the get and post requests handled by the application.
namespace AmazonProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Private variable for class use
        private IAmazonRepository _repository;

        public HomeController(ILogger<HomeController> logger, IAmazonRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //primary get action. will populate index page with the Books in the database.
        public IActionResult Index()
        {
            return View(_repository.Books);
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
