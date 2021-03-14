using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Controllers
{
    //[NonController]
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    //return Content("Firest Controller Action");
        //    return View();
        //}
        public IActionResult Index() => View();
        
        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");
    }
} 
