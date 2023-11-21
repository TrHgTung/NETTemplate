using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrinhHoangTung.Models;

namespace TrinhHoangTung.Controllers
{
    public class StudentController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _repo;
        public int PageSize = 1; // hien thi 1 sv moi trang

        public StudentController(IStudentRepository repo)
        {

            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.Students);
        }

        public IActionResult Pagnition(int studentPage = 1)
        {
            return View(_repo.Students
                .OrderBy(p => p.Id)
                .Skip((studentPage - 1) * PageSize)
                .Take(PageSize)
                );
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