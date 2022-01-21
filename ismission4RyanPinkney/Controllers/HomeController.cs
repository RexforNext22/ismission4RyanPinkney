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

        // Route for the Movie
        public IActionResult Movie()
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
