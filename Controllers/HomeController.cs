using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PravallikaBandarlaFutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.FutureValueModels model)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View();
        }
    }
}
