using ASP_Lecture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_Lecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Cat c = new Cat()
            {
                Name = "Yumi",
                Description = "The largest problem"
            };
            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Greeting()
        {
            ViewBag.Project = "ASP Project";
            return View();
        }
        public IActionResult info()
        {
            ViewData["Name"] = "Connor";
            ViewData["Age"] = 23;
            return View();
        }
        public IActionResult CatForm()
        {
            return View();
        }
        //any value sent through form must be caught by parameters
        //[HttpPost]
        //public IActionResult CatResult(string Name, string Description)
        //{
        //    Cat c = new Cat(Name, Description);
        //    return View(c);
        //}
        //if form values match an object, you can just take in an object
        public IActionResult CatResult(Cat c)
        {
            return View(c);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}