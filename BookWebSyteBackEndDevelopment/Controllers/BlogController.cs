using Microsoft.AspNetCore.Mvc;

namespace BookWebSyteBackEndMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
