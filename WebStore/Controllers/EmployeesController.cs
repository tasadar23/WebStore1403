using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index() => View();
    }
}
