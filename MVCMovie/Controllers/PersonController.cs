using System.Net;
using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourProject.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin Chào" + ps.PersonId + "_" + ps.FullName + "_" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();

        }
    }
}
