using Microsoft.AspNetCore.Mvc;

namespace ProductsManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}