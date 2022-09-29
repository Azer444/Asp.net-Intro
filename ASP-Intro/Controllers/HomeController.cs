using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro.Controllers
{
    public class HomeController : Controller
    {


        //public string Index(int id)
        //{
        //    return "Salam Azer" + "-" + id;
        //}

        //public IActionResult Index()
        //{
        //    return Content("Salamlar");
        //}

        //public string FullData(string name, string surname, int age)
        //{
        //    return $"Name - {name} Surname - {surname} Age - {age}";
        //}

        //public IActionResult Index()
        //{
        //    return Json(new { name = "Azer", surname = "Humbetov" });
        //}

        public IActionResult Index()
        {
            return View();
        }



    }
}
