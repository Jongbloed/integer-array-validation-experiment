using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntegerArrayValidation.Models;
using System.Text.RegularExpressions;

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
                var input = Regex.Matches(model.InputText, "[0-9]+")
                    .Select(match => int.Parse(match.Value))
                    .ToArray();
                var output = Triplicate.DetermineLinq(input);
                model.Answer = $"[{string.Join(",", output)}]";
            }
            else
            {
                model.Answer = "Nope!";
            }
            return View(model);
        }
    }
}
