using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class Bai1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai1 model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }
            return View();
        }
    }
}
