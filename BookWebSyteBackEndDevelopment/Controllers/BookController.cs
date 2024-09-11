using Microsoft.AspNetCore.Mvc;

namespace BookWebSyteBackEndMVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
