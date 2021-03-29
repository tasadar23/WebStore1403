using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.Serialization;
using WebStore.Infrastructure.Conventions;
using WebStore.Infrastructure.Filters;

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
        [AddHeader("Test","Header value")]
        public IActionResult Index() => View();

        public IActionResult Throw() => throw new ApplicationExeption("Test error!");

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

    [Serializable]
    internal class ApplicationExeption : Exception
    {
        public ApplicationExeption()
        {
        }

        public ApplicationExeption(string message) : base(message)
        {
        }

        public ApplicationExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApplicationExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
