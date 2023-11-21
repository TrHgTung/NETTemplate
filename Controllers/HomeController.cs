using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrinhHoangTung.Models;

namespace TrinhHoangTung.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _repo;

        public HomeController(IStudentRepository repo)
        {
            
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.Students);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}