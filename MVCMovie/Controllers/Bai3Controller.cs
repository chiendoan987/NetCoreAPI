using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class Bai3Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai3 model)
        {
            if (ModelState.IsValid && model.ChieuCao > 0)
            {
                model.BMI = model.CanNang / (model.ChieuCao * model.ChieuCao);

                if (model.BMI < 18.5)
                    model.PhanLoai = "Gầy";
                else if (model.BMI < 24.9)
                    model.PhanLoai = "Bình thường";
                else if (model.BMI < 29.9)
                    model.PhanLoai = "Thừa cân";
                else
                    model.PhanLoai = "Béo phì";

                return View("Result", model);
            }

            return View();
        }
    }
}
