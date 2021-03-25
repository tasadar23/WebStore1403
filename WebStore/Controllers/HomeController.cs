using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Conventions;

namespace WebStore.Controllers
{
    //[NonController]
    [ActionDescription("Главный контролер")]
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    //return Content("Firest Controller Action");
        //    return View();
        //}
        [ActionDescription("Главное действие")]

        public IActionResult Index() => View();

        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");    
        
        public IActionResult Contact() => View();
        public IActionResult Error404() => View();
        public IActionResult Blog() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Cart() => View();
        public IActionResult Checkout() => View();
        public IActionResult Login() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Shop() => View();
    }
}
