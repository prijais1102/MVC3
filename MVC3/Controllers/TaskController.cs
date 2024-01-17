using Microsoft.AspNetCore.Mvc;
using MVC3.Models;

namespace MVC3.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            Number number = new Number();
            return View(number);
        }
        [HttpPost]
        public IActionResult Add(Number number) 
        {
            ViewBag.res = number.No1 + number.No2;
            return View();

        }
    }
}
