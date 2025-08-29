using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Đây là trang Index của Person";
            return View();
        }

        public IActionResult Detail()
        {
            ViewBag.Message = "Đây là trang Detail của Person";
            return View();
        }
    }
}
