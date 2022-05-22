using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BlogController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
