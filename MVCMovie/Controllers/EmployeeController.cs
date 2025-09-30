using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Models
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Đây là trang Index của Employee";
            return View();
        }

        public IActionResult Profile()
        {
            ViewBag.Message = "Đây là trang Profile của Employee";
            return View();
        }
    }
}
