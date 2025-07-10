using System.Diagnostics;
using LearningWithNamDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningWithNamDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            logger.LogInformation("HomeController initialized.");
        }

        public IActionResult Index()
        {
            return View(new HelloModel() { Name = "Quốc Kỳ"});
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NewAction(string name)
        {
            return Content("This is a new action in the HomeController." + " Name: " + name);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
