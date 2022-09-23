using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookModel _bookModel;

        public HomeController(ILogger<HomeController> logger, IBookModel bookModel)
        {
            _logger = logger;
            _bookModel = bookModel;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("I am in index page.");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("I am in privacy page.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}