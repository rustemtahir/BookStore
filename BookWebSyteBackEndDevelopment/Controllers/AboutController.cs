using Microsoft.AspNetCore.Mvc;

namespace BookWebSyteBackEndMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
