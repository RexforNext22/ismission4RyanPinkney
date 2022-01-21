using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ismission4RyanPinkney.Models;

namespace ismission4RyanPinkney.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Route for the index
        public IActionResult Index()
        {
            return View();
        }

        // Route for the privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Route for the Podcast
        public IActionResult Podcast()
        {
            return View();
        }

        // Route for the get Movie
        [HttpGet]
        public IActionResult Movie()
        {
            return View();
        }

        // Route for the post Movie
        [HttpPost]
        public IActionResult Movie(Movie response)
        {
            // Save the infomration to the database
            blahContext.Add(response);
            blahContext.SaveChanges();

            return View("com", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
