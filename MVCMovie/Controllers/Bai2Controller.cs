using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai2 model)
        {
            if (ModelState.IsValid)
            {
                switch (model.PhepTinh)
                {
                    case "Tong":
                        model.KetQua = model.SoA + model.SoB;
                        break;
                    case "Hieu":
                        model.KetQua = model.SoA - model.SoB;
                        break;
                    case "Tich":
                        model.KetQua = model.SoA * model.SoB;
                        break;
                    case "Thuong":
                        model.KetQua = (model.SoB != 0) ? model.SoA / model.SoB : double.NaN;
                        break;
                }

                return View("Result", model);
            }

            return View();
        }
    }
}
