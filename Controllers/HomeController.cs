using System.Diagnostics;
using TodoList.Models;
using Microsoft.AspNetCore.Mvc;
using TodoList;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IRepository repository, ILogger<HomeController> logger)
        {
            this.repository = repository;
            _logger = logger;
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
        public IActionResult NewMyAction(string id) { 
            return Content("This is a new my action in the HomeController. " + repository.GetByID(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
