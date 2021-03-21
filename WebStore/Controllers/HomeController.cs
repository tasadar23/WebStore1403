using Microsoft.AspNetCore.Mvc;

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
        
        public IActionResult Contact() => View();
    }
}
