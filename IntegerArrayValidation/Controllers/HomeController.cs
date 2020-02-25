using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntegerArrayValidation.Models;

namespace IntegerArrayValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IntegerArrayInputModel model)
        {
            if (ModelState.IsValid)
            {
                model.Answer = "Valid";
            }
            else
            {
                model.Answer = "Nope!";
            }
            return View(model);
        }

    }
}
