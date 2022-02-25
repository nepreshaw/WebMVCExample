using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVCExample.Models;

namespace WebMVCExample.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            //viewbag is a built in dictionary. created so controllers can pass in data to the views
            //could createa a model for name and fv instead but would have to createa a seperate view
            ViewBag.Name = "Mary";
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model) {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}
